Param(
   [string] $Server = "(localdb)\MSSQLLocalDb",
   [string] $Database = "CIS560"
)

# This script requires the SQL Server module for PowerShell.
# The below commands may be required.

# To check whether the module is installed.
# Get-Module -ListAvailable -Name SqlServer;

# Install the SQL Server Module
# Install-Module -Name SqlServer -Scope CurrentUser

$CurrentDrive = (Get-Location).Drive.Name + ":"

Write-Host ""
Write-Host "Rebuilding database $Database on $Server..."

<#
   If on your local machine, you can drop and re-create the database.
#>
& ".\GameTracking\DropDatabase.ps1" -Database $Database
& ".\GameTracking\CreateDatabase.ps1" -Database $Database

<#
   If on the department's server, you don't have permissions to drop or create databases.
   In this case, maintain a script to drop all tables.
#>
#Write-Host "Dropping tables..."
#Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "GameTracking\Sql\Tables\DropTables.sql"

Write-Host "Creating schema..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "GameTracking\Sql\Schemas\GameTrack.sql"

Write-Host "Creating tables..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "GameTracking\Sql\Tables\GameTrack.Platform.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "GameTracking\Sql\Tables\GameTrack.Profile.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "GameTracking\Sql\Tables\GameTrack.Publisher.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "GameTracking\Sql\Tables\GameTrack.Developer.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "GameTracking\Sql\Tables\GameTrack.Genre.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "GameTracking\Sql\Tables\GameTrack.Game.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "GameTracking\Sql\Tables\GameTrack.Review.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "GameTracking\Sql\Tables\GameTrack.GameDeveloper.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "GameTracking\Sql\Tables\GameTrack.GameGenre.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "GameTracking\Sql\Tables\GameTrack.GamePlatform.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "GameTracking\Sql\Tables\GameTrack.GameProfile.sql"

Write-Host "Stored procedures..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "GameTracking\Sql\Procedures\Aggregating Procedures\GameTrack.GetDevelopersAndGamesDevelopedByGameGenre.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "GameTracking\Sql\Procedures\Aggregating Procedures\GameTrack.GetGamesAndAverageScoreByScoreAndGenre.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "GameTracking\Sql\Procedures\Aggregating Procedures\GameTrack.GetGamesAndReviewCountByTimePeriodAndReviewScore.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "GameTracking\Sql\Procedures\Aggregating Procedures\GameTrack.GetGamesAverageScoreAndReleaseDateByTimePeriod.sql"

Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "GameTracking\Sql\Procedures\Creation Procedures\GameTrack.CreateDeveloper.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "GameTracking\Sql\Procedures\Creation Procedures\GameTrack.CreateGame.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "GameTracking\Sql\Procedures\Creation Procedures\GameTrack.CreateGameDeveloper.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "GameTracking\Sql\Procedures\Creation Procedures\GameTrack.CreateGameGenre.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "GameTracking\Sql\Procedures\Creation Procedures\GameTrack.CreateGamePlatform.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "GameTracking\Sql\Procedures\Creation Procedures\GameTrack.CreateGameProfile.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "GameTracking\Sql\Procedures\Creation Procedures\GameTrack.CreateOrEditReview.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "GameTracking\Sql\Procedures\Creation Procedures\GameTrack.CreateProfile.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "GameTracking\Sql\Procedures\Creation Procedures\GameTrack.CreatePublisher.sql"

Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "GameTracking\Sql\Procedures\Fetch Procedures\GameTrack.FetchDeveloper.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "GameTracking\Sql\Procedures\Fetch Procedures\GameTrack.FetchGame.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "GameTracking\Sql\Procedures\Fetch Procedures\GameTrack.FetchGenre.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "GameTracking\Sql\Procedures\Fetch Procedures\GameTrack.FetchPlatform.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "GameTracking\Sql\Procedures\Fetch Procedures\GameTrack.FetchPublisher.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "GameTracking\Sql\Procedures\Fetch Procedures\GameTrack.FetchReview.sql"

Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "GameTracking\Sql\Procedures\Get By Unique Procedures\GameTrack.GetCriticByWebsite.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "GameTracking\Sql\Procedures\Get By Unique Procedures\GameTrack.GetDeveloperByEmail.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "GameTracking\Sql\Procedures\Get By Unique Procedures\GameTrack.GetDeveloperByName.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "GameTracking\Sql\Procedures\Get By Unique Procedures\GameTrack.GetGenreByName.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "GameTracking\Sql\Procedures\Get By Unique Procedures\GameTrack.GetPlatformByName.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "GameTracking\Sql\Procedures\Get By Unique Procedures\GameTrack.GetProfileByUsername.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "GameTracking\Sql\Procedures\Get By Unique Procedures\GameTrack.GetPublisherByName.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "GameTracking\Sql\Procedures\Get By Unique Procedures\GameTrack.GetReviewByGameID.sql"

Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "GameTracking\Sql\Procedures\Get Through Relationship Table\GameTrack.GetDevelopersForGame.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "GameTracking\Sql\Procedures\Get Through Relationship Table\GameTrack.GetGamesForProfile.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "GameTracking\Sql\Procedures\Get Through Relationship Table\GameTrack.GetGenresForGame.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "GameTracking\Sql\Procedures\Get Through Relationship Table\GameTrack.GetPlatformsForGame.sql"

Write-Host "Stored searching procedures..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "GameTracking\Sql\Procedures\Searching Procedures\GameTrack.SearchingDevelopers.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "GameTracking\Sql\Procedures\Searching Procedures\GameTrack.SearchingGames.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "GameTracking\Sql\Procedures\Searching Procedures\GameTrack.SearchingPublishers.sql"

Write-Host "Inserting data..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "GameTracking\Sql\Database Creation Procedures\GameTrack.InitializeDeveloper.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "GameTracking\Sql\Database Creation Procedures\GameTrack.InitializeGame.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "GameTracking\Sql\Database Creation Procedures\GameTrack.InitializeGenre.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "GameTracking\Sql\Database Creation Procedures\GameTrack.InitializePlatform.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "GameTracking\Sql\Database Creation Procedures\GameTrack.InitializeProfile.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "GameTracking\Sql\Database Creation Procedures\GameTrack.InitializePublisher.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "GameTracking\Sql\Database Creation Procedures\GameTrack.InitializeReview.sql"

Write-Host "Rebuild completed."
Write-Host ""

Set-Location $CurrentDrive
