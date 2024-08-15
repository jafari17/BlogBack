FROM node:18.10-alpine

WORKDIR /usr/src/app

COPY . /usr/src/app

RUN npm install -g @angular/cli@16.2.14

RUN npm install

 
CMD ["npm", "run", "json-run", "--host", "0.0.0.0"]
