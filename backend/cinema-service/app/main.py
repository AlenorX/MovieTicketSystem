import exception
import db
import models.model_api as model
import logging
from yaml_utilities import YAML
from fastapi import FastAPI, Response, status


app = FastAPI()
core = YAML()
dict_endpoints = core.deserialize("yaml/endpoints.yml")
endpoints = dict_endpoints['endpoints']
logging.basicConfig(
    level=logging.INFO,
    format="%(asctime)s [%(levelname)s] %(name)s: %(message)s"
)

@app.get(endpoints['status'])
async def healthcheck():
    return {"status": True, "message": "Microservice is alive"}

@app.get(endpoints['get-movie'])
async def get_movie(resp: Response):
    try:
        result = await db.get_movie()
        obj = model.MovieName(movie_name=result['movie_name'])
        return obj.model_dump()
    except exception.PostgresDBError:
        logging.exception("Internal database error")
        resp.status_code = status.HTTP_500_INTERNAL_SERVER_ERROR
        return {"status": True, "message": "Internal server error"}
    except Exception:
        logging.exception("Internal microservice error")
        resp.status_code = status.HTTP_500_INTERNAL_SERVER_ERROR
        return {"status": True, "message": "Internal server error"}

@app.get(endpoints['price-ticket'])
async def get_movie(resp: Response):
    try:
        result = await db.price_ticket()
        obj = model.PriceTicket(price_ticket=result['price_ticket'])
        return obj.model_dump()
    except exception.PostgresDBError:
        logging.exception("Internal database error")
        resp.status_code = status.HTTP_500_INTERNAL_SERVER_ERROR
        return {"status": True, "message": "Internal server error"}
    except Exception:
        logging.exception("Internal microservice error")
        resp.status_code = status.HTTP_500_INTERNAL_SERVER_ERROR
        return {"status": True, "message": "Internal server error"}
