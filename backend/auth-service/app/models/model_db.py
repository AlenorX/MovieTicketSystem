from pydantic import BaseModel

class User(BaseModel):
    user_id: str | None = None
    username: str
    balance: float

class UpdateBalance(BaseModel):
    user_id: str
    balance: float