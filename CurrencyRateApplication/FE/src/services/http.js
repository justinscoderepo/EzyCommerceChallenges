import axios from 'axios';

let envVars = Object.entries(import.meta.env).filter((key) => key[0].startsWith('VITE_'))
let apiRoot = envVars.find((key) => key[0].startsWith('VITE_API_URL'))[1];

const config = {
    headers: {
        'Content-Type': 'application/json',
    },
};

const axiosInstance = axios.create({
    baseURL: apiRoot,
});

const requestHandler = (request) => {
    request.headers.Platform = 'Web';
    return request;
};

const responseFailed = (error) => {
    return Promise.reject({ ...error });
};

const responseSuccess = (response) => {
    return response?.data;
};
function errorHandler(error) {
    if (error) {
        let { message } = error;
        console.log(message);
    }
}

if (axiosInstance.interceptors.request.handlers.length === 0) {
    axiosInstance.interceptors.request.use((request) => requestHandler(request));

    axiosInstance.interceptors.response.use(
        (response) => responseSuccess(response),
        (error) => responseFailed(error)
    );
}

export function get(path, model) {
    return new Promise((resolve, reject) => {
        if (path) {
            try {
                axiosInstance
                    .get(
                        apiRoot + path,
                        model,
                        config
                    )
                    .then((result) => {
                        resolve(result);
                    })
                    .catch((error) => {
                        errorHandler(error);
                        reject(error);
                    });
            } catch (error) {
                reject(error);
            }
        }
    });
}

