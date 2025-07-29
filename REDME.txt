Hello.
This is Joe's modified project from the original creator. Be sure to credit him on his page.
The difference:
The difference is that this project has been dockerized, and is capable of being published anywhere, along with a clean slate of a MongoDB database
docker-compose.yml contains the details regarding the container creation.
The Docker image has been set up for LINUX AND LINUX ONLY. Keep that in mind.
How it works:

Clone this project
Install these dependencies:

Production:
- express
- mongoose
- dotenv

Development:
- nodemon (for local dev only)

Installation Commands:
- npm install express mongoose dotenv
- npm install --save-dev nodemon

Tools Used:
- Docker & Docker Compose
- Kubernetes (optional)
- Watchtower (optional auto-update)

How to Run:
1. Install dependencies: `npm install`
2. Start app: `node index.js` or with nodemon: `npx nodemon index.js`

cd to your Docker location
Docker compose up
If all works, it should be accessible on your localhost or your ip:4000 and DB will be hosted on the default port of mongoDB

Possible problems: 
- Your docker compose doesn't work because of
Missing NPM
Or having a minor issue with the DockerFile because of the system calling nodemon and not npm.
Make sure to check the logs of the Docker image before proceeding.
Normally, the Docker container for the database doesn't have any sort of failures, so you shouldn't worry about it.
Happy deployment.
