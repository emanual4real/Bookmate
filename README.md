# Bookmate

Need an app to manage my books.  Seems like all the options out there kind of suck.

## Wanted Features
- file renaming - choose a schema and rename files/directories
- metadata updates
- cover updates
- automation of new books into some WebUi, could be calibre-web
- torrent searches for books
- generic, open api for anyone to use for any project
- Could simply read a directory where my torrent downloads live, then ingest them into the calibre database

## Setup
- Open VS Code
- Install Dev Containers
- Install Docker if not installed
- Open Repo folder and allow VS Code to open in container
- Make vs code default code editor
    - `git config --global core.editor "code --wait"`

## Migrations

`dotnet ef database update` - update database
`dotnet ef migrations add <migration-name>` - add new migration
`dotnet ef migrations remove` - remove last migration
