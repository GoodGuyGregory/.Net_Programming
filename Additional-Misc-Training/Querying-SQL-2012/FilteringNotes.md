## Filtering Notes

**Filtering with DISTINCT**

```sql
-- Returns all of the persons
SELECT * FROM Person.person;

-- Selects distinct people from the db:
-- Distinct only works with the first column field
SELECT DISTINCT persontype FROM Person.person;

```