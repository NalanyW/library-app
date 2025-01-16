
Inloggen

Admin
Email: admin@admin.com
Password: Test1234,

Employee
email: employee@mail.com
password2: Test123!

User
email: nalany@example.com
password2: Password1!


DEVELOPMENT:

Als localhost niet werkt in chrome:
1. in een terminal: dotnet dev-certs https --clean
2. verwijder keys uit C:\Users\%username%\AppData\Roaming\ASP.NET\https
3. in een terminal: dotnet dev-certs https --trust