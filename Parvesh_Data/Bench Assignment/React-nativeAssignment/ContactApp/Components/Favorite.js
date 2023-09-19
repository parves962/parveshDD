import React, {useState, useEffect,useIsFocused} from 'react';
import {
  FlatList,
  StyleSheet,
  Text,
  TouchableOpacity,
  View,
  Button,
  Image,
} from 'react-native';

import {openDatabase} from 'react-native-sqlite-storage';

let db = openDatabase({name: 'ContactDatabase.db'});



const Favorite = ({navigation})=>{
    const [userList, setUserList] = useState([]);
 
 
  useEffect(() => {
    getData();
  });

  const getData = () => {
    db.transaction(tx => {
      tx.executeSql('SELECT * FROM contact WHERE favorite_contact = ?', [1], (tx, results) => {
        var temp = [];
        for (let i = 0; i < results.rows.length; ++i)
          temp.push(results.rows.item(i));
        setUserList(temp);
      });
    });
  };
   return(
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
                  width: 30,
                  height: 30,
                  borderRadius: 400,
                  borderWidth: 0.3,
                }}
                source={{uri: item.image}}></Image>
              <Text style={styles.text}>{item.name}</Text>
              
            </TouchableOpacity>
          </View>
        )}
      />
   </View>)
}

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
     borderRadius:10
    
  },
  text: {
    fontSize: 20,
    paddingLeft: 30,
   
  },
  });

export default Favorite;