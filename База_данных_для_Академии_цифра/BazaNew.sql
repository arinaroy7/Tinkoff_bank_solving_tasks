// Задание 1. Скрипт для создания базы данных Mobile_operators_subscribers

CREATE TABLE Пользователи (
    id BIGSERIAL,
    Имя VARCHAR(50),
    Фамилия VARCHAR(50),
    Дата_рождения DATE,
    Город VARCHAR(100),
    Улица VARCHAR(100),
    Дом INTEGER,
    Почта VARCHAR(150),
    Гендер VARCHAR(50)
);

