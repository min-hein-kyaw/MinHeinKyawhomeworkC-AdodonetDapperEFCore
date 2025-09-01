<h1>Homework for reviewing AdoDotNetService, Dapper and EFCore Services</h1>
<h3>Features</h3>
<ul>
  <li>Create</li>
  <li>Read</li>
  <li>Update</li>
  <li>Delete</li>
</ul>
<ol>
  <li><h2>AdoDotNet Servie</h2></li>
  <ul><li>Learned From AdoDotNet</li>
  <li><ul>
    <li>SQL Connection String Builder</li>
    <li>SQL Connection</li>
    <li>Query</li>
    <li>SQL Data Adaper</li>
    <li>Data Table to fill in SQL Data Adapter</li>
    <li>Execute Non Query</li>
  </ul></li>
  </ul>
  
  <li><h2>Dapper Service</h2></li>
  <ul>
    <li>Learned from Dapper Service</li>
  <ul>
    <li>Create a class for the database</li>
    <li>IDBConnection as interface</li>
    <li> <dynamic> to <ClassName> and list to store the table </li>
    <li>CRUD command of execute</li>
    <li>names in class name and database name should be the same else there are problems</li>
  </ul>
  </ul>
  
  <li><h2>EFCore Service</h2></li>
  <ul><li>Learned From EFCore Service</li>
  <ul>
    <li>creating tableDTO class</li>
    <li>AppDBContext inheriting from DBContext and overiding onConfiguring function with SQL connection string builder and using optionBuilder to connect sql connection string and name the tableDTO class to suitable name </li>
    <li>Creating EFCore service class and add functions of crud</li>
    <li>Creating db from appDBContext</li>
    <li>To read db.table.toList to get list item of table and loop it to read</li>
    <li>To create, create object from DTOclass with needed properties, add properties to db and save changes </li>
    <li>To update, db.table.where(data => data.id == required id).firstOrDefault if there's an item update where it should</li>
    <li>To delete, same as update change the delete flag to false</li>
  </ul>
  </ul>
  


  
 
</ol>

