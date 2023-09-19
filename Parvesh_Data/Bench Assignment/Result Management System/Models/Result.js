const {Sequelize, DataTypes} = require("sequelize");

const sequelize = new Sequelize(
    'rms',
    'root',
    'root',
     {
       host: 'localhost',
       dialect: 'mysql',
       define:{        
           createdAt:false,     
           timestamps: false,        
           updatedAt:false      
        }
     }
   );
   
   
   
sequelize.authenticate().then(() => {
    console.log('Connection has been established successfully.');
}).catch((error) => {
    console.error('Unable to connect to the database: ', error);
});

const Result = sequelize.define("result", {
    rollno: {
      type: DataTypes.INTEGER,
      allowNull: false
    },
    name: {
      type: DataTypes.STRING,
      allowNull: false
    },
    dob: {
      type: DataTypes.DATEONLY,
    },
    score: {
      type: DataTypes.INTEGER,
    }
 });
 
 sequelize.sync().then(() => {
    console.log('result table created successfully!');
 }).catch((error) => {
    console.error('Unable to create table : ', error);
 });

module.exports = Result;