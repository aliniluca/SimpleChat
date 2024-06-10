CREATE TABLE User
(
   user_id              INTEGER     PRIMARY KEY AUTOINCREMENT,
   email_address        TEXT        NOT NULL,
   password             TEXT        NOT NULL,
   source               TEXT        NOT NULL,
   first_name           TEXT,
   last_name            TEXT,
   profile_picture_url  TEXT,
   date_of_birth        DATETIME,
   about_me             TEXT,
   notifications        INTEGER,
   dark_theme           INTEGER,
   created_date         DATE
);

CREATE TABLE ChatHistory
(
   chat_history_id   INTEGER     PRIMARY KEY AUTOINCREMENT,
   from_user_id      INT     NOT NULL,
   to_user_id        INT     NOT NULL,
   message           TEXT    NOT NULL,
   created_date      DATE    NOT NULL,
   FOREIGN KEY(from_user_id) REFERENCES User(user_id),
   FOREIGN KEY(to_user_id) REFERENCES User(user_id)
);

INSERT INTO User (user_id,email_address,password,source,first_name,last_name,profile_picture_url,
date_of_birth,about_me,notifications,dark_theme,created_date)
VALUES
(1,'julius.clarkson@gmail.com','julius.clarkson','APPL','Julius','Clarkson',NULL,NULL,NULL,1,1,NULL),
(2,'daniel.martinez@gmail.com','daniel.martinez','APPL','Daniel','Martinez',NULL,NULL,NULL,0,0,NULL),
(3,'gary.anderson@gmail.com','gary.anderson','APPL','Gary','Anderson',NULL,NULL,NULL,0,0,NULL),
(4,'martin.johansson@gmail.com','martin.johansson','APPL','Martin','Johansson',NULL,NULL,NULL,0,0,NULL),
(5,'howard.peters@gmail.com','howard.peters','APPL','Howard','Peters',NULL,NULL,NULL,0,0,NULL),
(6,'margaret.jones@gmail.com','margaret.jones','APPL','Margaret','Jones',NULL,NULL,NULL,0,0,NULL),
(7,'carine.dupont@gmail.com','carine.dupont','APPL','Carine','Dupont',NULL,NULL,NULL,0,0,NULL),
(8,'mary.stewart@gmail.com','mary.stewart','APPL','Mary','Stewart',NULL,NULL,NULL,0,0,NULL),
(9,'annette.brooks@gmail.com','annette.brooks','APPL','Annette','Brooks',NULL,NULL,NULL,0,0,NULL),
(10,'diego.mendez@gmail.com','diego.mendez','APPL','Diego','Mendez',NULL,NULL,NULL,0,0,NULL);
