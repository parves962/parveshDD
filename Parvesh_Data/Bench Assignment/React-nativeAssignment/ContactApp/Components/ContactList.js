import React, {useState, useEffect} from 'react';
import {
  FlatList,
  StyleSheet,
  Text,
  TouchableOpacity,
  View,
  Button,
  Image,
} from 'react-native';
import {NavigationContainer, useIsFocused} from '@react-navigation/native';
import {createNativeStackNavigator} from '@react-navigation/native-stack';
import Ionicons from 'react-native-vector-icons/Ionicons';

import {openDatabase} from 'react-native-sqlite-storage';


let db = openDatabase({name: 'ContactDatabase.db'});

const ContactList = ({navigation}) => {
  const [userList, setUserList] = useState([]);
  const [contactList, setcontactList] = useState([]);

  const isFocused = useIsFocused();

  useEffect(() => {
    getData();
  }, [isFocused]);

  const getData = () => {
    db.transaction(tx => {
      tx.executeSql('SELECT * FROM contact', [], (tx, results) => {
        var temp = [];
        for (let i = 0; i < results.rows.length; ++i)
          temp.push(results.rows.item(i));
        setUserList(temp);
      });
    });
  };



  const createTable = () => {
    db.transaction(txn => {
      txn.executeSql(
        'CREATE TABLE IF NOT EXISTS contact (id INTEGER PRIMARY KEY AUTOINCREMENT, name VARCHAR(30), number INTEGER(50), landline_number INTEGER(15), image VARCHAR(500),favorite_contact BOOLEAN)',

        [],

        (sqlTxn, res) => {
          console.log('Table Created Successfullyy');
        },

        error => {
          console.log('error on creating table ' + error.message);
        },
      );
    });
  };

  
  useEffect(() => {
    
    createTable();
  });

  
  return (
    <View style={styles.container}>
      <FlatList
        data={userList}
        renderItem={({item, index}) => (
          <View style={styles.row}>
            <TouchableOpacity
               style={styles.row}
              onPress={() =>
                navigation.navigate('ContactProfile', {item: {id: item.id}})
              }>
              <Image
                style={{
                  width: 50,
                  height: 50,
                  borderRadius: 400,
                  borderWidth: 0.3,
                  
                }}
                source={{uri: item.image}}></Image>
              <Text style={styles.text}>{item.name}</Text>
             
            </TouchableOpacity>
          </View>
        )}
      />
      <TouchableOpacity style={styles.ico} onPress={() => navigation.navigate('AddContact')}>
      <Ionicons name='add-circle' size={62} color='green'></Ionicons>
      </TouchableOpacity>
      
      
    </View>
  );
};

const styles = StyleSheet.create({
  container: {
    flex: 1,
    
  },
  row: {
    flexDirection: 'row',
   
    backgroundColor:'rgba(255, 255, 255, 0.9)',
    paddingLeft: 5,
     paddingTop: 10,
     paddingLeft:10,
     marginBottom:10,
     borderRadius:10,
     textAlign:'auto'
  },
  text: {
    fontSize: 20,
    paddingLeft: 30,
   
  },
  ico : {
    
   
    justifyContent: 'flex-end',
    alignItems: 'flex-end',
    
    bottom: 20,

        right: 20,

        position: 'absolute',

        zIndex: 1,
  }
  
});

export default ContactList;
