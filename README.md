# MovieTicketSystem

## Документация по микросервисам:
1. Endpoints:
 - **1.1 Cinema-service:**
    - •/cinema/status - Статус микросервиса (GET)
    - • /cinema/movie - Получить список фильмов (GET)
    - • /cinema/price - Получить цену за один билет (GET)
 - **1.2 Auth-service:**
    - • /auth/registration - Регистрация пользователей (POST)
    - • /auth/user/{id} - Получить информацию пользователя по user_id (GET)
    - • /auth/update/balance - Обновить баланс пользователя (PATCH)