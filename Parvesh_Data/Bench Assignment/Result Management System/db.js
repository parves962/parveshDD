const Sequelize = require("sequelize");
const sequelize = new Sequelize(
   'rms',
   'root',
   'root',
   {
      host: 'localhost',
      dialect: 'mysql',
      define: {
         createdAt: false,
         timestamps: false,
         updatedAt: false
      }
   }
);



sequelize.authenticate().then(() => {
   console.log('Connection has been established successfully.');
}).catch((error) => {
   console.error('Unable to connect to the database: ', error);
});

module.exports = sequelize;