DELETE FROM admissions
DELETE FROM bills
DELETE FROM charges
DELETE FROM emergencyContact
DELETE FROM insurance
DELETE FROM notes
DELETE FROM patients
DELETE FROM prescriptions
DELETE FROM procedures
DELETE FROM users
DELETE FROM visitors

DBCC CHECKIDENT (admissions, RESEED, 0)
DBCC CHECKIDENT (bills, RESEED, 0)
DBCC CHECKIDENT (charges, RESEED, 0)
DBCC CHECKIDENT (emergencyContact, RESEED, 0)
DBCC CHECKIDENT (insurance, RESEED, 0)
DBCC CHECKIDENT (notes, RESEED, 0)
DBCC CHECKIDENT (patients, RESEED, 0)
DBCC CHECKIDENT (prescriptions, RESEED, 0)
DBCC CHECKIDENT (procedures, RESEED, 0)
DBCC CHECKIDENT (visitors, RESEED, 0)