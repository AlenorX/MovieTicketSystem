import asyncpg
import exception
import models.model_db as model
from yaml_utilities import YAML


core = YAML()
mongo_config = core.deserialize("yaml/configuration.yml")
config = mongo_config['postgres']


async def registration(model: model.User):
    try:
        connect = await asyncpg.connect(host=config['host'], port=config['port'], user=config['username'], database=config['CinemaBase'])
        await connect.execute('INSERT INTO users (user_id, username, balance) VALUES ($1, $2)', model.user_id, model.username, model.balance)
    except Exception as e:
        raise exception.PostgresDBError(f'Ошибка при выполнении запроса в БД: {e}') from e
    finally:
        connect.close()

async def get_user(user_id: str):
    try:
        connect = await asyncpg.connect(host=config['host'], port=config['port'], user=config['username'], database=config['CinemaBase'])
        records = await connect.fetchrow('SELECT username, balance FROM users WHERE user_id = $1', id)
        return records
    except Exception as e:
        raise exception.PostgresDBError(f'Ошибка при выполнении запроса в БД: {e}') from e
    finally:
        connect.close()


async def update_balance(model: model.UpdateBalance):
    try:
        connect = await asyncpg.connect(host=config['host'], port=config['port'], user=config['username'], database=config['CinemaBase'])
        await connect.execute('UPDATE users SET balance = $1 WHERE id = $2', model.new_balance, model.new_balance)
    except Exception as e:
        raise exception.PostgresDBError(f'Ошибка при выполнении запроса в БД: {e}') from e
    finally:
        connect.close()

