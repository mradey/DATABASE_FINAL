/* SQL script to run test queries on and retrieve test data from the database. */

/* Query 1: UNION
 Retrieve information about employees (e.g., SSN and name) who have dependents or are department managers. 
*/ 
SELECT SSN, FNAME, LNAME 
FROM Employee
WHERE SSN IN (SELECT ESSN
			 FROM Dependent)
UNION
SELECT SSN, FNAME, LNAME 
FROM Employee
WHERE SSN IN (SELECT MGRSSN
			  FROM Department);

/* Query 2: INTERSECT
 Retrieve information about employees (e.g., SSN and name) who are department managers and have dependents  */
SELECT SSN, FNAME, LNAME 
FROM Employee
WHERE SSN IN (SELECT ESSN
			 FROM Dependent)
INTERSECT
SELECT SSN, FNAME, LNAME 
FROM Employee
WHERE SSN IN (SELECT MGRSSN
			  FROM Department);

/* Query 3: EXCEPT
 Retrieve information about employees who work on projects but they are not department managers having dependents */
SELECT SSN, FNAME, LNAME 
FROM Employee
WHERE SSN IN (SELECT ESSN
			 FROM Works_On)
EXCEPT
(SELECT SSN, FNAME, LNAME 
FROM Employee
WHERE SSN IN (SELECT ESSN
			 FROM Dependent)
INTERSECT
SELECT SSN, FNAME, LNAME 
FROM Employee
WHERE SSN IN (SELECT MGRSSN
			  FROM Department));


/* Query 4: DIVISION
Retrieve information about employees who have worked on all projects */
SELECT SSN, LNAME, FNAME
FROM EMPLOYEE 
WHERE NOT EXISTS( SELECT PNUMBER
				  FROM PROJECT
				  WHERE NOT EXISTS( SELECT *
									FROM WORKS_ON
									WHERE PNUMBER = PNO AND ESSN = SSN));

/* Query 5: AGGREGATE FUNCTION COUNT
 Retrieve information about each project 
 (e.g., project number & name) and (next to it) number of employees worked on the account.  */
SELECT PNUMBER, PNAME, (SELECT COUNT(*) FROM Works_On AS W WHERE P.PNUMBER = W.PNO) AS EMPLOYEE_COUNT
FROM Project As P


/* Query 6: MULTIPLE JOINS
Query 6: Retrieve employees (ssn & lname), their 
department managers (ssn & lname) and the projects (pnumber & pname) they both worked on.  */

SELECT E.SSN, E.LNAME, S.SSN, S.LNAME, P.PNAME, P.PNUMBER
FROM Employee AS E
INNER JOIN Employee S ON E.SUPPERSSN = S.SSN
INNER JOIN Works_On WE ON E.SSN = WE.ESSN
INNER JOIN Works_On WS ON S.SSN = WS.ESSN AND WE.PNO = WS.PNO
INNER JOIN Project P ON WE.PNO = P.PNUMBER



