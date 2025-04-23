// Название БД Mobile_operators_subscribers

CREATE DATABASE Mobile_operators_subscribers; 

// Создаем базу данных \l - проверка создана ли. \c mobile_operators_subscribers - подсоединяемся к бд. \conninfo - подкл к бд

//DROP TABLE Имя; - удаление бд / \d - посмотреть список созданных таблиц
// Удаление всего DROP TABLE "Пользователи" CASCADE;

CREATE TABLE Пользователи (
    id BIGSERIAL NOT NULL PRIMARY KEY,
    Имя VARCHAR(50) NOT NULL,
    Фамилия VARCHAR(50) NOT NULL,
    Дата_рождения DATE NOT NULL,
    Город VARCHAR(100) NOT NULL,
    Улица VARCHAR(100) NOT NULL,
    Дом INTEGER NOT NULL,
    Почта VARCHAR(150),
    Гендер VARCHAR(50) NOT NULL
);
