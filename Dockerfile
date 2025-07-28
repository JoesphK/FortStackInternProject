# Base image
FROM node:18

# Create app directory
WORKDIR /app

# Install app dependencies
COPY package*.json ./
RUN npm install

# Copy app source code
COPY . .

# Expose the correct port
EXPOSE 4000

# Start the app
CMD ["npm", "start"]
