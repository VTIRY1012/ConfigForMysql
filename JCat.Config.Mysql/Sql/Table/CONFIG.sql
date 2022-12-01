--
-- Create table `CONFIG`
--
CREATE TABLE CONFIG (
  id VARCHAR(50) NOT NULL,
  `key` VARCHAR(50) NOT NULL,
  `value` VARCHAR(500) NOT NULL,
  `version` INT NOT NULL,  
  `status` VARCHAR(50) NOT NULL,  
  creator VARCHAR(50) NOT NULL,
  create_at DATETIME NOT NULL,
  modifier VARCHAR(50) NOT NULL,
  modify_at DATETIME NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_0900_ai_ci;