-- CREATE TABLE accounts (
--    id VARCHAR(255) NOT NULL,
--    name VARCHAR(255) NOT NULL,
--    email VARCHAR(255) NOT NULL,
--    picture VARCHAR(255) NOT NULL,
--    PRIMARY KEY (id)
-- );

-- CREATE TABLE recipes (
--   id int NOT NULL AUTO_INCREMENT,
--   creatorId VARCHAR(255) NOT NULL, 
--   name VARCHAR(255) NOT NULL,
--   description VARCHAR(255),
--   cookTime INT NOT NULL, 

--   PRIMARY KEY(id),

--   FOREIGN KEY(creatorId)
--   REFERENCES accounts(id)
--   ON DELETE CASCADE
-- );

-- CREATE TABLE ingredients (
--   id int NOT NULL AUTO_INCREMENT,
--   recipeId INT NOT NULL, 
--   name VARCHAR(255) NOT NULL,
--   quantity VARCHAR(255),
--   creatorId VARCHAR(255) NOT NULL, 

--   PRIMARY KEY(id),

--   FOREIGN KEY(recipeId)
--   REFERENCES recipes(id)
--   ON DELETE CASCADE,

--   FOREIGN KEY(creatorId)
--   REFERENCES accounts(id)
--   ON DELETE CASCADE
-- );