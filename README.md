# Twitter
Its a Social Media App to learn and implement Full Stack functionalities

# Migration - 
dotnet ef migrations add TweetDBAdded -p Persistance -c TweetContext -o TweetMigrationScript -s TweetAPI

dotnet ef migrations add IdentityAdded -p Persistance -c UserContext -o TweetUserMigrationScript -s UserAPI 

# Update Database - 
dotnet ef database update IdentityAdded -p Persistance -c UserContext -s UserAPI

dotnet ef database update TweetDBAdded -p Persistance -c TweetContext -s TweetAPI

