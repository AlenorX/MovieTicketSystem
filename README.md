# MovieTicketSystem

## Документация по микросервисам:
1. Endpoints:
**Cinema-service:**
 - /cinema/status - Статус микросервиса (GET)
 - /cinema/movie - Получить список фильмов (GET)
 - /cinema/price - Получить цену за один билет (GET)
 
**Auth-service:**
 - /auth/registration - Регистрация пользователей (POST)
 - /auth/user/{id} - Получить информацию пользователя по id (GET)
 - /auth/update/balance - Обновить баланс пользователя (PATCH)