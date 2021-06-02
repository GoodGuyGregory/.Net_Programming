## Querying Microsoft Sequal Server 2012:


**Intellisense**

When Selecting items from a DB use the intellisense by specifying the table with the **FROM** clause

```sql
SELECT -- Login... etc
-- intellisense would find the table below if FROM was typed
FROM HumanResources.?
```

**Alias Calls**

using an Alias helps with inner joins and organization, as well as brevity in queries

```sql
SELECT hre.Login, hre.JobTitle, hre.HireDate
FROM HumanResources AS hre;
GO
```

This can also be done with table queries

```sql
SELECT hre.Login AS [Login], hre.JobTitle AS [Title], hre.HireDate AS [Hire Date]
FROM HumanResources AS hre;
GO
```

**CASE Statement Examples**

used when wanting to clarify examples from queries for the untrained eye

```sql
SELECT First_Name, Last_Name, 
CASE Person_Type
    WHEN 'SC' THEN 'Store Contact'
    WHEN 'EM' THEN 'Employee'
    WHEN 'DS' THEN 'Direct Supporvisor'
    WHEN 'DM' THEM 'Department Manager'
    ELSE 'Unknown Relational COntact'
END AS [Type of Contact]
FROM HumanResources.Employees

```