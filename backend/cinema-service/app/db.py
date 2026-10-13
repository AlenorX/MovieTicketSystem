import asyncpg
import exception
from yaml_utilities import YAML


core = YAML()
mongo_config = core.deserialize("yaml/configuration.yml")
config = mongo_config['postgres']


async def get_movie():
    try:
        connect = await asyncpg.connect(host=config['host'], port=config['port'], user=config['username'], database=config['CinemaBase'])
        records = await connect.fetchrow('SELECT movie_name FROM cinema')
        return records
    except Exception as e:
        raise exception.PostgresDBError(f'Ошибка при выполнении запроса в БД: {e}') from e
    finally:
        connect.close()

async def price_ticket():
    try:
        connect = await asyncpg.connect(host=config['host'], port=config['port'], user=config['username'], database=config['CinemaBase'])
        records = await connect.fetchrow('SELECT price_ticket FROM cinema')
        return records
    except Exception as e:
        raise exception.PostgresDBError(f'Ошибка при выполнении запроса в БД: {e}') from e
    finally:
        connect.close()
