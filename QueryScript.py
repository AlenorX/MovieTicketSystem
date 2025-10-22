import sqlite3
import os

core = sqlite3.connect('base.db', check_same_thread=False)
cursor = core.cursor()
path = "base.db"

def CreateTable():
    cursor.execute('CREATE TABLE Users (login VARCHAR(255) NOT NULL PRIMARY KEY, password VARCHAR(255) NOT NULL, Money INTEGER)')

def SignIn(login, password):
    cursor.execute('SELECT login, money FROM Users WHERE login = ? AND password = ?', (login, password))
    result = cursor.fetchall()
    return result

def Registration(login, password):
    cursor.execute('INSERT INTO Users (login, password, money) VALUES (?, ?, ?)', (login, password, 500))
    core.commit()
    cursor.execute('SELECT login, money FROM Users WHERE login = ? AND password = ?', (login, password))
    result = cursor.fetchall()
    return result

def BuyTicket(login, money):
    cursor.execute('UPDATE Users SET money = ? WHERE login = ?', (money, login))
    core.commit()

