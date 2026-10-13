from pydantic import BaseModel

class MovieName(BaseModel):
    movie_name: list

class PriceTicket(BaseModel):
    price_ticket: float

