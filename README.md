# TutorMangementSystem

The web app uses ASP.Net Core and the MVC pattern.
<img width="1098" alt="1" src="https://user-images.githubusercontent.com/29239699/62756972-45e74080-ba3f-11e9-9c1a-41e3cace0602.PNG">

A user (student) can Browse through a collection list of available tutors that one can reserve. The user can view the tutor image, name, cost of tutoring, the subject the tutor teaches.
<img width="1095" alt="2" src="https://user-images.githubusercontent.com/29239699/62756973-467fd700-ba3f-11e9-82e3-84a7ccfcfddc.PNG">

Clicking on a tutor will bring you to a more detailed page.
<img width="1129" alt="3a" src="https://user-images.githubusercontent.com/29239699/62756974-467fd700-ba3f-11e9-8ba7-b45e480a43e2.PNG">

Hitting the reserve button will take you to the page where the user can place a reservation on the specific tutor using their system member card ID number (i.e. 2)
<img width="1127" alt="3b" src="https://user-images.githubusercontent.com/29239699/62756975-47186d80-ba3f-11e9-80e1-d6a397a34a4c.PNG">

Once the reservation was made successful the web app will redirect to the Tutor Info page where the status should be updated to "Reserved" and the user now has the option to remove their reservation as well. Bellow the info card a list of all reservations made is shown.
<img width="1127" alt="3c" src="https://user-images.githubusercontent.com/29239699/62756976-47186d80-ba3f-11e9-9ed3-2d5e10bf43b1.PNG">

This is the student index page where a list of all students is shown. Student deletion or changes can be made directly here and will be reflected in the database. Clicking the Register button will take one to the Register page where they can insert new students.
<img width="1129" alt="4" src="https://user-images.githubusercontent.com/29239699/62756977-47186d80-ba3f-11e9-9767-c840b6395452.PNG">
<img width="1128" alt="4b" src="https://user-images.githubusercontent.com/29239699/62756978-47186d80-ba3f-11e9-94f6-28cbb1183a5d.PNG">

This is the Office index page where a list of all office locations arer shown. A user can quickly galance if the office is open and the number of tutors/students it has.
<img width="1128" alt="5" src="https://user-images.githubusercontent.com/29239699/62756979-47186d80-ba3f-11e9-85ae-83770fea085b.PNG">

Clicking on a office name will take one to the Office Deatail page where it highlights more information on a speific office branch.
<img width="1123" alt="5b" src="https://user-images.githubusercontent.com/29239699/62756980-47186d80-ba3f-11e9-8b79-65d9cbfac0ef.PNG">

# To Configure DB
Open SQL Server Management Studio, right click on "Databases" -> "Attach..." -> "Add.." -> browse through and link the given TutorDB.mdf file
