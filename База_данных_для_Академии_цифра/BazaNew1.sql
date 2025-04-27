-- Задание 1. Скрипт для создания базы данных Mobile_operators_subscribers.

CREATE DATABASE Mobile_operators_subscribers; 

-- Подключение к базе данных и ее создание.

\l
\c mobile_operators_subscribers
\conninfo

CREATE TABLE Пользователи (
    id BIGSERIAL PRIMARY KEY,
    Имя VARCHAR(50),
    Фамилия VARCHAR(50),
    Дата_рождения DATE,
    Город VARCHAR(100),
    Улица VARCHAR(100),
    Дом INTEGER,
    Почта VARCHAR(150),
    Гендер VARCHAR(50)
);

CREATE TABLE Номера_телефонов (
    id BIGSERIAL PRIMARY KEY,
    Номер BIGINT UNIQUE,
    id_оператора INTEGER,
    id_пользователя INTEGER,
    FOREIGN KEY (id_оператора) REFERENCES Операторы(id),
    FOREIGN KEY (id_пользователя) REFERENCES Пользователи(id)
);

CREATE TABLE Операторы (
    id BIGSERIAL PRIMARY KEY,
    Имя_оператора VARCHAR(100),
    Тариф VARCHAR(200),
    Стоимость_тарифа INTEGER
);

CREATE TABLE История_смены_оператора (
    id BIGSERIAL PRIMARY KEY,
    Дата_смены DATE,
    id_номера BIGINT,
    Предыдущий_оператор_id INTEGER,
    Новый_оператор_id INTEGER,
    Предыдущий_пользователь_id INTEGER,
    Новый_пользователь_id INTEGER,
    FOREIGN KEY (id_номера) REFERENCES Номера_телефонов(id),
    FOREIGN KEY (Предыдущий_оператор_id) REFERENCES Операторы(id),
    FOREIGN KEY (Новый_оператор_id) REFERENCES Операторы(id),
    FOREIGN KEY (Предыдущий_пользователь_id) REFERENCES Пользователи(id),
    FOREIGN KEY (Новый_пользователь_id) REFERENCES Пользователи(id)
);