Create database if not exists wsc;

use wsc;

Create User  'Web01'@'localhost'  IDENTIFIED BY 'H1gh12SeaHawk!!';

grant select, Delete, Drop, Event, Insert, Lock Tables,  
Update, create temporary tables  on *.* to 'Web01'@'localhost';


CREATE TABLE IF NOT EXISTS `WSC`.`users` (
  `userid` INT NOT NULL AUTO_INCREMENT,
  `typeid` INT NOT NULL,
  `userlogin` VARCHAR(45) NOT NULL,
  `passwrd` VARCHAR(45) NOT NULL,
  `firstname` VARCHAR(50) NOT NULL,
  `lastname` VARCHAR(50) NOT NULL,
  `middlename` VARCHAR(45) NULL,
  `email` VARCHAR(100) NULL,
  `Address1` VARCHAR(75) NOT NULL,
  `Address2` VARCHAR(75) NULL,
  `City` VARCHAR(45) NOT NULL,
  `ustate` VARCHAR(2) NOT NULL,
  `zipcode` VARCHAR(15) NULL,
  `phonenumber` VARCHAR(15) NOT NULL,
  `startdate` DATETIME NOT NULL,
  `enddate` DATETIME NULL,
  `status` INT NOT NULL DEFAULT 1,
  PRIMARY KEY (`userid`),
  UNIQUE INDEX `userid_UNIQUE` (`userid` ASC),
  INDEX `type_useer_idx` (`typeid` ASC),
  CONSTRAINT `type_user`
    FOREIGN KEY (`typeid`)
    REFERENCES `WSC`.`type` (`typeid`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;



CREATE TABLE IF NOT EXISTS `WSC`.`product` (
  `productid` INT NOT NULL AUTO_INCREMENT,
  `productdescription` VARCHAR(2000) NOT NULL,
  `producttype` VARCHAR(45) NOT NULL,
  `wholesalecost` FLOAT(6,2) NOT NULL,
  `retailcost` FLOAT(6,2) NOT NULL,
  `currentstock` INT NOT NULL,
  `ImageUrl` VARCHAR(100) CHARACTER SET 'big5' NULL,
  `productadvertising` VARCHAR(500) NULL,
  PRIMARY KEY (`productid`),
  UNIQUE INDEX `productid_UNIQUE` (`productid` ASC))
ENGINE = InnoDB;

/* Type is the security type for users this tables is loaded when the users are
	add to the system and the levels are
    0 Not an active user
    1 Customer
    2 Employee
    3 Manager
*/
CREATE TABLE IF NOT EXISTS `WSC`.`type` (
  `typeid` INT NOT NULL AUTO_INCREMENT,
  `userid` INT NOT NULL,
  `Description` VARCHAR(45) NOT NULL,
  `level` INT NULL,
  PRIMARY KEY (`typeid`),
  UNIQUE INDEX `typeid_UNIQUE` (`typeid` ASC),
  INDEX `userid_idx` (`userid` ASC),
  CONSTRAINT `userid_type`
    FOREIGN KEY (`userid`)
    REFERENCES `WSC`.`users` (`userid`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS `WSC`.`Catalog` (
  `itemid` INT NOT NULL AUTO_INCREMENT,
  `productid` INT NOT NULL,
  `catalogdescription` VARCHAR(2000) NULL,
  PRIMARY KEY (`itemid`),
  UNIQUE INDEX `itemid_UNIQUE` (`itemid` ASC),
  INDEX `productid_idx` (`productid` ASC),
  CONSTRAINT `productid`
    FOREIGN KEY (`productid`)
    REFERENCES `WSC`.`product` (`productid`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


CREATE TABLE IF NOT EXISTS `WSC`.`Orders` (
  `orderid` INT NOT NULL AUTO_INCREMENT,
  `itemid` INT NOT NULL,
  `userid` INT NOT NULL,
  `itemcount` INT NOT NULL,
  `amount` FLOAT(6,2) NOT NULL,
  `Description` VARCHAR(2000) NOT NULL,
  `adjustments` FLOAT(6,2) NULL,
  `orderdate` DATETIME NOT NULL,
  `validation` INT(1) NOT NULL DEFAULT 0,
  `fullfilled` VARCHAR(45) NOT NULL DEFAULT 0,
  PRIMARY KEY (`orderid`),
  INDEX `userid_idx` (`userid` ASC),
  INDEX `itemid_idx` (`itemid` ASC),
  UNIQUE INDEX `orderid_UNIQUE` (`orderid` ASC),
  CONSTRAINT `userid`
    FOREIGN KEY (`userid`)
    REFERENCES `WSC`.`users` (`userid`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `itemid`
    FOREIGN KEY (`itemid`)
    REFERENCES `WSC`.`Catalog` (`itemid`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS `WSC`.`Sales` (
  `salesid` INT NOT NULL AUTO_INCREMENT,
  `userid` INT NOT NULL,
  `description` VARCHAR(2000) NOT NULL,
  `active` INT(1) NOT NULL DEFAULT 1,
  PRIMARY KEY (`salesid`),
  UNIQUE INDEX `salesid_UNIQUE` (`salesid` ASC),
  INDEX `userid_idx` (`userid` ASC),
  CONSTRAINT `userid_Sales`
    FOREIGN KEY (`userid`)
    REFERENCES `WSC`.`users` (`userid`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS `WSC`.`Purchase` (
  `billingid` INT NOT NULL AUTO_INCREMENT,
  `orderid` INT NOT NULL,
  `userid` INT NOT NULL,
  `salerid` INT NOT NULL,
  `currentorderamount` FLOAT(6,2) NOT NULL,
  `orderamount` FLOAT(6,2) NOT NULL,
  `autopay` INT NOT NULL DEFAULT 0,
  PRIMARY KEY (`billingid`),
  UNIQUE INDEX `billingid_UNIQUE` (`billingid` ASC),
  INDEX `orderid_idx` (`orderid` ASC),
  INDEX `userid_idx` (`userid` ASC),
  INDEX `salesid_purchase_idx` (`salerid` ASC),
  CONSTRAINT `orderid_purchase`
    FOREIGN KEY (`orderid`)
    REFERENCES `WSC`.`Orders` (`orderid`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `userid_purchase`
    FOREIGN KEY (`userid`)
    REFERENCES `WSC`.`users` (`userid`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `salesid_purchase`
    FOREIGN KEY (`salerid`)
    REFERENCES `WSC`.`Sales` (`salesid`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

use wsc;

set foreign_key_checks = false;

INSERT INTO `WSC`.`users` (`typeid`, `userlogin`, `passwrd`, `firstname`, `lastname`, `middlename`, `email`, `Address1`, `Address2`, `City`, `ustate`, `zipcode`, `phonenumber`, `startdate`, `enddate`, `status`) 
VALUES (1, 'spool', 'password1', 'Steve', 'Pool', '', 'spool@email.com', '123 Barrow Ln', null, 'City1', 'MA', '12345-0987', '1234567890', '2014-01-01', NULL, 1);
INSERT INTO `WSC`.`users` ( `typeid`,`userlogin`, `passwrd`, `firstname`, `lastname`, `middlename`, `email`, `Address1`, `Address2`, `City`, `ustate`, `zipcode`, `phonenumber`, `startdate`, `enddate`, `status`) 
VALUES (1,'ckent', 'password2', 'Clark', 'Kent', '', 'spool@email.com', '434 Eagle Str', '','City1', 'MA', '09876', '2234567890', '2012-01-01', NULL, 1);
INSERT INTO `WSC`.`users` ( `typeid`,`userlogin`, `passwrd`, `firstname`, `lastname`, `middlename`, `email`, `Address1`, `Address2`, `City`, `ustate`, `zipcode`, `phonenumber`, `startdate`, `enddate`, `status`) 
VALUES (1,'pmarshal', 'password1', 'Penny', 'Marshal', '', 'spool@email.com', '98798 Elm pl', '',  'City1', 'MA', '65432-8765', '3234567890', '2010-01-01', NULL, 1);
INSERT INTO `WSC`.`users` ( `typeid`,`userlogin`, `passwrd`, `firstname`, `lastname`, `middlename`, `email`, `Address1`, `Address2`, `City`, `ustate`, `zipcode`, `phonenumber`, `startdate`, `enddate`, `status`) 
VALUES (2,'lcarter', 'password1', 'Linda', 'Carter', '', 'spool@email.com', '3433 SE Melborne St', '', 'City1', 'MA', '56789', '4234567890', '2004-01-01', NULL, 1);
INSERT INTO `WSC`.`users` ( `typeid`,`userlogin`, `passwrd`, `firstname`, `lastname`, `middlename`, `email`, `Address1`, `Address2`, `City`, `ustate`, `zipcode`, `phonenumber`, `startdate`, `enddate`, `status`) 
VALUES (3,'daykroyd', 'password1', 'Dan', 'Aykroyd', '', 'spool@email.com', '7899 Glenwood Str E', null, 'City1', 'MA', '34567', '5234567890', '2014-01-01', NULL, 1);


INSERT INTO `WSC`.`product` (`productdescription`, `producttype`, `wholesalecost`, `retailcost`, `currentstock`, `productadvertising`) 
VALUES ('StarWars Tee-Shirt', 'Clothes', 6.95, 21.25, 248, 'May the Force be with you');
INSERT INTO `WSC`.`product` (`productdescription`, `producttype`, `wholesalecost`, `retailcost`, `currentstock`, `productadvertising`) 
VALUES ('Star Jeans', 'Clothes', 16.95, 45.95, 148,'Look like you fell from the Stars.');
INSERT INTO `WSC`.`product` (`productdescription`, `producttype`, `wholesalecost`, `retailcost`, `currentstock`, `productadvertising`) 
VALUES ('Bowling Trophy Woman', 'Trophy', 6.95, 21.25, 68,'For Winners Only. No exceptions.');
INSERT INTO `WSC`.`product` (`productdescription`, `producttype`, `wholesalecost`, `retailcost`, `currentstock`, `productadvertising`) 
VALUES ('Bowling Trophy Man', 'Trophy', 6.95, 21.25, 72,'Only Winners Here.');
INSERT INTO `WSC`.`product` (`productdescription`, `producttype`, `wholesalecost`, `retailcost`, `currentstock`, `productadvertising`) 
VALUES ('baseball plaques', 'Plaques', 16.95, 46.75, 48,'For Winners Only. No exceptions.');
INSERT INTO `WSC`.`product` (`productdescription`, `producttype`, `wholesalecost`, `retailcost`, `currentstock`, `productadvertising`) 
VALUES ('Team Trophy 3 People Top', 'Trophy', 76.95, 221.25, 8,'Flies to the Winners Circle.');

INSERT INTO `WSC`.`type` (`userid`, `Description`, `level`) 
VALUES (1, 'Customer', 1);
INSERT INTO `WSC`.`type` (`userid`, `Description`, `level`) 
VALUES (2, 'Customer', 1);
INSERT INTO `WSC`.`type` (`userid`, `Description`, `level`) 
VALUES (3, 'Customer', 1);
INSERT INTO `WSC`.`type` (`userid`, `Description`, `level`) 
VALUES (4, 'Employee', 2);
INSERT INTO `WSC`.`type` (`userid`, `Description`, `level`) 
VALUES (5, 'Manager', 3);


INSERT INTO `WSC`.`Sales` (`userid`, `description`, `active`) 
VALUES (4, 'North Town', 1);
INSERT INTO `WSC`.`Sales` (`userid`, `description`, `active`) 
VALUES (5, 'South Town', 1);


INSERT INTO `WSC`.`Catalog` (`productid`, `catalogdescription`) 
VALUES (1, 'cat description 1');
INSERT INTO `WSC`.`Catalog` (`productid`, `catalogdescription`) 
VALUES (2, 'cat description 2');
INSERT INTO `WSC`.`Catalog` (`productid`, `catalogdescription`) 
VALUES (3, 'cat description 3');
INSERT INTO `WSC`.`Catalog` (`productid`, `catalogdescription`) 
VALUES (4, 'cat description 4');
INSERT INTO `WSC`.`Catalog` (`productid`, `catalogdescription`) 
VALUES (5, 'cat description 5');


INSERT INTO `WSC`.`Orders` (`itemid`, `userid`, `itemcount`, `amount`, `Description`, `adjustments`, `orderdate`, `validation`, `fullfilled`) 
VALUES (2, 1, 1, 21.25, 'StarWars Tee-Shirt', 2.08, '2016-05-17', 0, 0);
INSERT INTO `WSC`.`Orders` (`itemid`, `userid`, `itemcount`, `amount`, `Description`, `adjustments`, `orderdate`, `validation`, `fullfilled`) 
VALUES (3, 3, 1, 21.25, 'Bowling Trophy Woman', 0, '2016-05-01', 0, 0);
INSERT INTO `WSC`.`Orders` (`itemid`, `userid`, `itemcount`, `amount`, `Description`, `adjustments`, `orderdate`, `validation`, `fullfilled`) 
VALUES (4, 3, 1, 21.25, 'Bowling Trophy Man', 0, '2016-05-01', 0, 0);
INSERT INTO `WSC`.`Orders` (`itemid`, `userid`, `itemcount`, `amount`, `Description`, `adjustments`, `orderdate`, `validation`, `fullfilled`) 
VALUES (5, 2, 1, 45.95, 'Star Jeans', 0, '2016-05-17', 0, 0);
INSERT INTO `WSC`.`Orders` (`itemid`, `userid`, `itemcount`, `amount`, `Description`, `adjustments`, `orderdate`, `validation`, `fullfilled`) 
VALUES (1, 2, 1, 21.25, 'StarWars Tee-Shirt', 0, '2016-05-17', 0, 0);


INSERT INTO `WSC`.`Purchase` (`orderid`, `userid`, `salerid`, `currentorderamount`, `orderamount`, `autopay`) 
VALUES (1, 2, 1, 21.25, 21.25, 0);
INSERT INTO `WSC`.`Purchase` (`orderid`, `userid`, `salerid`, `currentorderamount`, `orderamount`, `autopay`) 
VALUES (2, 3, 2, 21.25, 42.50, 0);
INSERT INTO `WSC`.`Purchase` (`orderid`, `userid`, `salerid`, `currentorderamount`, `orderamount`, `autopay`) 
VALUES (3, 3, 2, 21.25, 42.50, 0);
INSERT INTO `WSC`.`Purchase` (`orderid`, `userid`, `salerid`, `currentorderamount`, `orderamount`, `autopay`) 
VALUES (4, 2, 1, 45.95, 67.20, 0);
INSERT INTO `WSC`.`Purchase` (`orderid`, `userid`, `salerid`, `currentorderamount`, `orderamount`, `autopay`) 
VALUES (5, 2, 1, 21.25, 67.20, 0);

set foreign_key_checks=true;

/*Delimiter //
create procedure PurchaseSales (in saler int, out curamt float)
Begin
select p.orderid, p.userid, p.currentorderamount 
from Purchase as p left join sales as s on p.salerid = s.salesid 
where p.salerid = 2;saler;
End//
Delimiter ;*/
