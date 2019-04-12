CREATE OR REPLACE VIEW person_list_v AS 
SELECT
per.person_id AS 'USER ID',
per.first_name AS 'FIRST NAME',
per.last_name AS 'LAST NAME',
per.dob AS 'DOB',
per.gender AS 'GENDER',
addr.street_address AS 'STREET ADDRESS',
addr.city AS 'CITY',
addr.state AS 'STATE',
addr.postal_code AS 'ZIP CODE',
per.phone AS 'PHONE'
FROM person AS per, address AS addr
WHERE per.address_id = addr.address_id;
    
SELECT * FROM person_list_v;