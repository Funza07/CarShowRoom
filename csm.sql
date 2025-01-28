-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 27, 2024 at 06:56 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `csm`
--

-- --------------------------------------------------------

--
-- Table structure for table `account`
--

CREATE TABLE `account` (
  `MANF_ORDER` varchar(15) DEFAULT NULL,
  `CUST_ORDER` varchar(15) DEFAULT NULL,
  `AMOUNT` int(11) DEFAULT NULL,
  `IS_PAID` varchar(5) NOT NULL,
  `PAYMENT_DATE` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `account`
--

INSERT INTO `account` (`MANF_ORDER`, `CUST_ORDER`, `AMOUNT`, `IS_PAID`, `PAYMENT_DATE`) VALUES
('MOD001', 'COD001', 1700000, 'TRUE', '2023-04-20');

-- --------------------------------------------------------

--
-- Table structure for table `car`
--

CREATE TABLE `car` (
  `CAR_ID` varchar(15) NOT NULL,
  `CAR_NAME` varchar(20) NOT NULL,
  `CAR_MODEL` char(4) NOT NULL,
  `CAR_COMPANY` varchar(15) NOT NULL,
  `CAR_STATUS` varchar(10) NOT NULL,
  `CAR_PRICE` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `car`
--

INSERT INTO `car` (`CAR_ID`, `CAR_NAME`, `CAR_MODEL`, `CAR_COMPANY`, `CAR_STATUS`, `CAR_PRICE`) VALUES
('CAR001', 'Civic', '2022', 'Honda', 'Available', 1500000),
('CAR003', 'Sedan', '2012', 'Audi', 'Sold', 345399),
('CAR004', 'Model S', '2023', 'Tesla', 'Available', 75000),
('CAR005', 'Civic', '2022', 'Honda', 'Available', 25000),
('CAR006', 'Corolla', '2021', 'Toyota', 'Available', 22000),
('CAR007', 'Mustang', '2023', 'Ford', 'Available', 55000),
('CAR008', 'Accord', '2022', 'Honda', 'Sold', 30000),
('CAR009', 'Camry', '2021', 'Toyota', 'Sold', 28000),
('CAR010', 'Model 3', '2023', 'Tesla', 'Sold', 45000),
('CAR011', 'Explorer', '2023', 'Ford', 'Sold', 40000),
('CAR012', 'RAV4', '2022', 'Toyota', 'Available', 32000),
('CAR013', 'F-150', '2023', 'Ford', 'Available', 45000),
('CAR014', 'Outlander', '2021', 'Mitsubishi', 'Available', 27000),
('CAR015', 'Altima', '2022', 'Nissan', 'Sold', 24000),
('CAR016', 'Sentra', '2023', 'Nissan', 'Sold', 21000),
('CAR017', 'Wrangler', '2023', 'Jeep', 'Sold', 40000),
('CAR018', 'Tucson', '2022', 'Hyundai', 'Available', 29000),
('CAR019', 'Elantra', '2021', 'Hyundai', 'Sold', 20000),
('CAR020', 'Civic', '2022', 'Honda', 'Sold', 25000),
('CAR021', 'Corolla', '2021', 'Toyota', 'Sold', 22000),
('CAR022', 'Charger', '2022', 'Dodge', 'Sold', 38000),
('CAR023', 'Cherokee', '2021', 'Jeep', 'Sold', 35000),
('CAR024', 'A4', '2023', 'Audi', 'Sold', 45000),
('CAR025', 'Q5', '2022', 'Audi', 'Sold', 42000),
('CAR026', 'X5', '2023', 'BMW', 'Sold', 60000),
('CAR027', '3 Series', '2022', 'BMW', 'Available', 55000),
('CAR028', 'C-Class', '2023', 'Mercedes', 'Available', 50000),
('CAR029', 'E-Class', '2022', 'Mercedes', 'Sold', 65000),
('CAR030', 'Range Rover', '2023', 'Land Rover', 'Sold', 85000),
('CAR031', 'F-150', '2023', 'Ford', 'Sold', 45000),
('CAR032', 'Model S', '2023', 'Tesla', 'Available', 75000),
('CAR033', 'Camry', '2021', 'Toyota', 'Available', 28000),
('CAR034', 'Explorer', '2023', 'Ford', 'Available', 40000),
('CAR035', 'RAV4', '2022', 'Toyota', 'Available', 32000),
('CAR036', 'Altima', '2022', 'Nissan', 'Sold', 24000),
('CAR037', 'Sentra', '2023', 'Nissan', 'Sold', 21000),
('CAR038', 'Wrangler', '2023', 'Jeep', 'Sold', 40000),
('CAR039', 'Civic', '2022', 'Honda', 'Available', 25000),
('CAR040', 'Corolla', '2021', 'Toyota', 'Available', 22000),
('CAR041', 'Mustang', '2023', 'Ford', 'Available', 55000),
('CAR042', 'Outlander', '2021', 'Mitsubishi', 'Sold', 27000);

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `CUSTOMER_CNIC` char(13) NOT NULL,
  `CUSTOMER_NAME` varchar(25) NOT NULL,
  `CUSTOMER_CONTACT` char(13) NOT NULL,
  `CUSTOMER_ADDRESS` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`CUSTOMER_CNIC`, `CUSTOMER_NAME`, `CUSTOMER_CONTACT`, `CUSTOMER_ADDRESS`) VALUES
('1234567890123', 'John Doe', '9876543210', 'Mumbai'),
('32423324', 'sadsadadas', '343434', 'cvxvxcvxcvc'),
('3433434434674', 'Mango', '43536867823', 'World'),
('4445456-45454', 'Toni Deori', '987876863', 'Assam'),
('454556-454545', 'Ball', '87887876677', 'Cat'),
('45665-656543-', 'Jack Sir', '87454566643', 'Japan '),
('4576876543', 'Goku', '6866435647', 'Saiyan Planet'),
('46546456445', 'Zarha', '3242424232', 'Assam'),
('543543543543', 'fdsgfd', '435445454', 'gfdgdfgdf'),
('565464654654', 'Tanmoy Dutta ', '7686786754', 'Sri Lanka'),
('67743-566534-', 'Peter Parker', '7654563452', 'NYC, USA'),
('765456784556', 'Puru', '5689985657', 'Bistupur, Jamshedput\r\nBistupur, Jamshedpur'),
('784568751', 'Ruhan', '456768787', 'Tipura'),
('8644565774', 'Tanmay', '3367787564', 'Lanka'),
('8765565453453', 'Luffy ', '56878784555', 'Raft tale, New Island');

-- --------------------------------------------------------

--
-- Table structure for table `customer_order`
--

CREATE TABLE `customer_order` (
  `ORDER_ID` varchar(15) NOT NULL,
  `EMPLOYEE_ID` varchar(15) DEFAULT NULL,
  `CAR_ID` varchar(15) DEFAULT NULL,
  `CUSTOMER_CNIC` char(13) DEFAULT NULL,
  `ORDER_DATE` date NOT NULL,
  `BILL` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `customer_order`
--

INSERT INTO `customer_order` (`ORDER_ID`, `EMPLOYEE_ID`, `CAR_ID`, `CUSTOMER_CNIC`, `ORDER_DATE`, `BILL`) VALUES
('1192', NULL, 'CAR020', '67743-566534-', '2024-11-24', 26500),
('1374', NULL, 'CAR011', '45665-656543-', '2024-11-25', 41500),
('2430', NULL, 'CAR026', '565464654654', '2024-11-24', 61500),
('2478', NULL, 'CAR003', '765456784556', '2024-11-24', 346899),
('4017', NULL, 'CAR042', '8765565453453', '2024-11-24', 28500),
('4060', NULL, 'CAR001', '784568751', '2024-11-24', 1501500),
('4626', NULL, 'CAR001', '32423324', '2024-11-24', 1501500),
('5110', NULL, 'CAR019', '4445456-45454', '2024-11-25', 21500),
('5862', NULL, 'CAR001', '543543543543', '2024-11-24', 1501500),
('7292', NULL, 'CAR021', '4576876543', '2024-11-24', 23500),
('7389', NULL, 'CAR025', '46546456445', '2024-11-25', 43500),
('7562', NULL, 'CAR003', '454556-454545', '2024-11-25', 346899),
('7618', NULL, 'CAR001', '8644565774', '2024-11-24', 1501500),
('8699', NULL, 'CAR001', '3433434434674', '2024-11-24', 1501500),
('COD001', 'EMP001', 'CAR001', '1234567890123', '2023-04-15', 1700000);

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `Employee_ID` int(11) NOT NULL,
  `EMPLOYEE_NAME` varchar(25) NOT NULL,
  `EMPLOYEE_PASSWORD` char(8) NOT NULL,
  `EMPLOYEE_CONTACT` char(11) NOT NULL,
  `EMPLOYEE_ADDRESS` varchar(50) NOT NULL,
  `EMPLOYEE_EMAIL` varchar(25) NOT NULL,
  `EMPLOYEE_DESIGNATION` varchar(15) NOT NULL,
  `EMPLOYEE_HIREDATE` date NOT NULL,
  `EMPLOYEE_FIREDATE` date DEFAULT NULL,
  `EMPLOYEE_STATUS` varchar(10) NOT NULL,
  `EMPLOYEE_SALES` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`Employee_ID`, `EMPLOYEE_NAME`, `EMPLOYEE_PASSWORD`, `EMPLOYEE_CONTACT`, `EMPLOYEE_ADDRESS`, `EMPLOYEE_EMAIL`, `EMPLOYEE_DESIGNATION`, `EMPLOYEE_HIREDATE`, `EMPLOYEE_FIREDATE`, `EMPLOYEE_STATUS`, `EMPLOYEE_SALES`) VALUES
(1, 'Bikram Tripathi', 'password', '9931090555', 'Jamshedpur', 'bikram@gmail.com', 'Manager', '2022-01-15', NULL, 'Working', 5),
(2, 'John Smith', 'pass1234', '9876543210', '123 Elm Street, Cityville', 'johnsmith@example.com', 'Sales Represent', '2024-11-24', NULL, 'Working', 0),
(3, 'Joydeep Tripathi', 'pass1234', '7004019038', 'Vatika Green City, Jamshedpur', 'joy@gmail.com', 'Employee', '2024-11-24', NULL, 'Working', 0);

-- --------------------------------------------------------

--
-- Table structure for table `manufacturer`
--

CREATE TABLE `manufacturer` (
  `MANUFACTURER_ID` varchar(15) NOT NULL,
  `MANUFACTURER_NAME` varchar(25) NOT NULL,
  `MANUFACTURER_EMAIL` varchar(25) NOT NULL,
  `MANUFACTURER_ADDRESS` varchar(50) NOT NULL,
  `MANUFACTURER_CONTACT` char(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `manufacturer`
--

INSERT INTO `manufacturer` (`MANUFACTURER_ID`, `MANUFACTURER_NAME`, `MANUFACTURER_EMAIL`, `MANUFACTURER_ADDRESS`, `MANUFACTURER_CONTACT`) VALUES
('JHAS234234', 'Apple God', 'dfwdfwfwf!@dfdsf', 'qwdfasdfasdf afasfdsaf', '346434546'),
('MAN001', 'Honda Motors', 'honda@gmail.com', 'Delhi', '9876543210'),
('MAN002', 'Toyota Motor Corporation', 'support@toyota.com', '1 Toyota-cho, Toyota City, Aichi, Japan', '+81-565-28-'),
('MAN003', 'Ford Motor Company', 'contact@ford.com', 'World Headquarters, Dearborn, MI', '313-322-300'),
('MAN004', 'General Motors', 'info@gm.com', '300 Renaissance Center, Detroit, MI', '313-556-500'),
('MAN005', 'BMW Group', 'support@bmw.com', 'Petuelring 130, 80788 Munich, Germany', '+49-89-382-'),
('MAN006', 'Mercedes-Benz Group', 'service@mercedes.com', 'Mercedesstraße 120, 70372 Stuttgart, Germany', '+49-711-170'),
('MAN007', 'Honda Motor Co.', 'info@honda.com', '2-1-1 Minami-Aoyama, Minato-ku, Tokyo, Japan', '+81-3-3423-'),
('MAN008', 'Hyundai Motor Company', 'support@hyundai.com', '12, Heolleung-ro, Seocho-gu, Seoul, South Korea', '+82-2-3464-'),
('MAN009', 'Volkswagen AG', 'contact@vw.com', 'Berliner Ring 2, 38440 Wolfsburg, Germany', '+49-5361-9-'),
('MAN010', 'Nissan Motor Co.', 'support@nissan.com', '1-1 Takashima, Nishi-ku, Yokohama, Japan', '+81-45-523-'),
('MAN011', 'Kia Corporation', 'service@kia.com', '12 Heolleung-ro, Seocho-gu, Seoul, South Korea', '+82-2-3464-'),
('MAN012', 'Audi AG', 'info@audi.com', 'Ettinger Str. 70, 85057 Ingolstadt, Germany', '+49-841-89-'),
('MAN013', 'Porsche AG', 'support@porsche.com', 'Porscheplatz 1, 70435 Stuttgart, Germany', '+49-711-911'),
('MAN014', 'Volvo Cars', 'info@volvocars.com', 'Gothenburg, Sweden', '+46-31-325-'),
('MAN015', 'Chevrolet Division', 'service@chevrolet.com', '100 Renaissance Center, Detroit, MI', '800-222-102'),
('MAN016', 'Tesla Inc.', 'info@tesla.com', '3500 Deer Creek Road, Palo Alto, CA', '650-681-500');

-- --------------------------------------------------------

--
-- Table structure for table `manuf_order`
--

CREATE TABLE `manuf_order` (
  `ORDER_ID` varchar(15) NOT NULL,
  `EMPLOYEE_ID` varchar(15) DEFAULT NULL,
  `CAR_ID` varchar(15) DEFAULT NULL,
  `MANUFACTURER_ID` varchar(15) DEFAULT NULL,
  `ORDER_DATE` date NOT NULL,
  `BILL` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `manuf_order`
--

INSERT INTO `manuf_order` (`ORDER_ID`, `EMPLOYEE_ID`, `CAR_ID`, `MANUFACTURER_ID`, `ORDER_DATE`, `BILL`) VALUES
('MOD001', 'EMP001', 'CAR001', 'MAN001', '2023-03-15', 1500000);

-- --------------------------------------------------------

--
-- Table structure for table `sell_payment`
--

CREATE TABLE `sell_payment` (
  `ORDER_ID` varchar(15) DEFAULT NULL,
  `PAYMENT_DATE` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `sell_payment`
--

INSERT INTO `sell_payment` (`ORDER_ID`, `PAYMENT_DATE`) VALUES
('COD001', '2023-04-20');

-- --------------------------------------------------------

--
-- Table structure for table `stock`
--

CREATE TABLE `stock` (
  `ORDER_ID` varchar(15) DEFAULT NULL,
  `CAR_ID` varchar(15) DEFAULT NULL,
  `REC_DATE` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `stock`
--

INSERT INTO `stock` (`ORDER_ID`, `CAR_ID`, `REC_DATE`) VALUES
('MOD001', 'CAR001', '2023-03-20');

-- --------------------------------------------------------

--
-- Table structure for table `stock_payment`
--

CREATE TABLE `stock_payment` (
  `ORDER_ID` varchar(15) DEFAULT NULL,
  `PAYMENT_DATE` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `stock_payment`
--

INSERT INTO `stock_payment` (`ORDER_ID`, `PAYMENT_DATE`) VALUES
('MOD001', '2023-03-25');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `account`
--
ALTER TABLE `account`
  ADD KEY `MANF_ORDER` (`MANF_ORDER`),
  ADD KEY `CUST_ORDER` (`CUST_ORDER`);

--
-- Indexes for table `car`
--
ALTER TABLE `car`
  ADD PRIMARY KEY (`CAR_ID`);

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`CUSTOMER_CNIC`);

--
-- Indexes for table `customer_order`
--
ALTER TABLE `customer_order`
  ADD PRIMARY KEY (`ORDER_ID`),
  ADD KEY `EMPLOYEE_ID` (`EMPLOYEE_ID`),
  ADD KEY `CAR_ID` (`CAR_ID`),
  ADD KEY `CUSTOMER_CNIC` (`CUSTOMER_CNIC`);

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`Employee_ID`),
  ADD UNIQUE KEY `EMPLOYEE_EMAIL` (`EMPLOYEE_EMAIL`);

--
-- Indexes for table `manufacturer`
--
ALTER TABLE `manufacturer`
  ADD PRIMARY KEY (`MANUFACTURER_ID`),
  ADD UNIQUE KEY `MANUFACTURER_EMAIL` (`MANUFACTURER_EMAIL`);

--
-- Indexes for table `manuf_order`
--
ALTER TABLE `manuf_order`
  ADD PRIMARY KEY (`ORDER_ID`),
  ADD KEY `EMPLOYEE_ID` (`EMPLOYEE_ID`),
  ADD KEY `CAR_ID` (`CAR_ID`),
  ADD KEY `MANUFACTURER_ID` (`MANUFACTURER_ID`);

--
-- Indexes for table `sell_payment`
--
ALTER TABLE `sell_payment`
  ADD KEY `ORDER_ID` (`ORDER_ID`);

--
-- Indexes for table `stock`
--
ALTER TABLE `stock`
  ADD KEY `ORDER_ID` (`ORDER_ID`),
  ADD KEY `CAR_ID` (`CAR_ID`);

--
-- Indexes for table `stock_payment`
--
ALTER TABLE `stock_payment`
  ADD KEY `ORDER_ID` (`ORDER_ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `employee`
--
ALTER TABLE `employee`
  MODIFY `Employee_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `account`
--
ALTER TABLE `account`
  ADD CONSTRAINT `account_ibfk_1` FOREIGN KEY (`MANF_ORDER`) REFERENCES `manuf_order` (`ORDER_ID`),
  ADD CONSTRAINT `account_ibfk_2` FOREIGN KEY (`CUST_ORDER`) REFERENCES `customer_order` (`ORDER_ID`);

--
-- Constraints for table `customer_order`
--
ALTER TABLE `customer_order`
  ADD CONSTRAINT `customer_order_ibfk_2` FOREIGN KEY (`CAR_ID`) REFERENCES `car` (`CAR_ID`),
  ADD CONSTRAINT `customer_order_ibfk_3` FOREIGN KEY (`CUSTOMER_CNIC`) REFERENCES `customer` (`CUSTOMER_CNIC`);

--
-- Constraints for table `manuf_order`
--
ALTER TABLE `manuf_order`
  ADD CONSTRAINT `manuf_order_ibfk_2` FOREIGN KEY (`CAR_ID`) REFERENCES `car` (`CAR_ID`),
  ADD CONSTRAINT `manuf_order_ibfk_3` FOREIGN KEY (`MANUFACTURER_ID`) REFERENCES `manufacturer` (`MANUFACTURER_ID`);

--
-- Constraints for table `sell_payment`
--
ALTER TABLE `sell_payment`
  ADD CONSTRAINT `sell_payment_ibfk_1` FOREIGN KEY (`ORDER_ID`) REFERENCES `customer_order` (`ORDER_ID`);

--
-- Constraints for table `stock`
--
ALTER TABLE `stock`
  ADD CONSTRAINT `stock_ibfk_1` FOREIGN KEY (`ORDER_ID`) REFERENCES `manuf_order` (`ORDER_ID`),
  ADD CONSTRAINT `stock_ibfk_2` FOREIGN KEY (`CAR_ID`) REFERENCES `car` (`CAR_ID`);

--
-- Constraints for table `stock_payment`
--
ALTER TABLE `stock_payment`
  ADD CONSTRAINT `stock_payment_ibfk_1` FOREIGN KEY (`ORDER_ID`) REFERENCES `manuf_order` (`ORDER_ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
