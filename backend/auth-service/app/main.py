import exception
import db
import models.model_api as model
import logging
import bcrypt
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

@app.post(endpoints['registration'])
async def registration(resp: Response, schema: model.User):
    try:
        await db.registration(schema)
        resp.status_code = status.HTTP_201_CREATED
        return {"status": True, "message": "Success"}
    except exception.PostgresDBError:
        logging.exception("Internal database error")
        resp.status_code = status.HTTP_500_INTERNAL_SERVER_ERROR
        return {"status": True, "message": "Internal server error"}
    except Exception:
        logging.exception("Internal microservice error")
        resp.status_code = status.HTTP_500_INTERNAL_SERVER_ERROR
        return {"status": True, "message": "Internal server error"}

@app.get(endpoints['get-user'] + "{id}")
async def get_user(resp: Response, id: str):
    try:
        result = await db.get_user(id)
        obj = model.User(**result)
        return obj.model_dump()
    except exception.PostgresDBError:
        logging.exception("Internal database error")
        resp.status_code = status.HTTP_500_INTERNAL_SERVER_ERROR
        return {"status": True, "message": "Internal server error"}
    except Exception:
        logging.exception("Internal microservice error")
        resp.status_code = status.HTTP_500_INTERNAL_SERVER_ERROR
        return {"status": True, "message": "Internal server error"}

@app.patch(endpoints['update-balance'])
async def update_balance(resp: Response, schema: model.UpdateBalance):
    try:
        await db.update_balance(schema)
        resp.status_code = status.HTTP_202_ACCEPTED
        return {"status": True, "message": "Success"}
    except exception.PostgresDBError:
        logging.exception("Internal database error")
        resp.status_code = status.HTTP_500_INTERNAL_SERVER_ERROR
        return {"status": True, "message": "Internal server error"}
    except Exception:
        logging.exception("Internal microservice error")
        resp.status_code = status.HTTP_500_INTERNAL_SERVER_ERROR
        return {"status": True, "message": "Internal server error"}
