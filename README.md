# Microservices Communication with RabbitMQ
This repository demonstrates Microservices asynchronous communication through RabbitMQ

### Setup
1. Start the RabbitMQ server using the following command.
    ```bash
    docker run --rm -it -p 15672:15672 -p 5672:5672 rabbitmq:3-management
    ```
2. Update the Connection strings and `RABBIT_MQ_SERVER` addressess in the `docker-compose.yml` file
3. Change to the root directory of the solution and run the following command
    ```bash
    docker-compose up --build
    ```
    This will build the containers and start the application.

You can now access the applications swagger documents with the following endpoints
1. http://localhost:4201/swagger/index.html
2. http://localhost:4202/swagger/index.html