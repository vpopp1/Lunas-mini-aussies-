# Lunas-mini-aussies-
3312 Final Project 

This will be the comment page on thoughts and processes that go into the project. Some of my pages 
don't let me comment correctly, it adds code instead of actually commenting it out. 

the models were an easy set up, but the migrations were a hassle. It kept saying the path was not found
so I had to find out how to set that up.

export PATH="$PATH:$HOME/.dotnet/tools/" was the code needed in the terminal to let the migrations set up. 

This was after making sure all of the tools were updated and I made sure that I had the correct versions downloaded. 
Line 10 has to be used before dotnet ef or it won't run. 

Question for later, when the migrations is edited that becomes the go to file and makes the prior invalid? I edited the migrations
because I only used lower case in the variable name, renamed it later but to set it up it was all lowercase, and it wouldn't run. Then it did run once I updated, logically it makes sense but would like to make sure. 

after the scaffolding was done, since it was a 1:M relationship, had to add navigation properties that were almost forgotten, and seed more data with a few clients. The program keeps giving me an error with the code the scaffolding created, it says the namespace is the type when the its an entity and then the object. 

Added a few clients to own puppies on the seeddata model

line 38, 40 create.cshtml.cs were part of a debug option, it said it was a nullable factor and to 
run correct the program added those lines 

addClient razorpage and model done, modeled after the create puppy page giving the client a drop down box to ad 1-3 choices on avaliable pups 

added the paging code to both index.cshtml and index.cshtml.cs, for previous page if pagenum was less than or equal to 1 it would disable, for next linq to count puppies in list, then answer divided by page size, then rounded up and if pagenum +1 = to the answer it would disable. 