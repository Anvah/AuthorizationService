Авторизационный сервис предоставляющий возможности для создания аккаунта и получения автаризационного токена
Сервис не подключен к базе данных, данные храняться в статическом поле до презагрузки сервиса.

Проект развернут в docker-контейнерах в облаке Azure. Примеры успешых запросов:

Авторизация: https://flightserviceauthservice.azurewebsites.net/api/Auth/authenticate { "username": "user1", "password": "password1" }

Создание аккаунта: https://flightserviceauthservice.azurewebsites.net/api/Auth/createAccount { "username": "user3", "password": "password3" }
