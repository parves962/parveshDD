import {useIsFocused} from '@react-navigation/native';
import React, {useState, useEffect} from 'react';
import {
  Text,
  View,
  Button,
  StyleSheet,
  Dimensions,
  FlatList,
  Image,
  StatusBar,
  ImageBackground,
  TouchableOpacity,
  Alert,
} from 'react-native';
import {openDatabase} from 'react-native-sqlite-storage';
import Icon from 'react-native-vector-icons/Ionicons';

let db = openDatabase({name: 'ContactDatabase.db'});
const ContactProfile = ({navigation, route}) => {
  const id = route.params.item.id;

  const [contactList, setContactList] = useState([]);
  const isFocused = useIsFocused();

  

  const handleDelete = () => {
    db.transaction(tx => {
      tx.executeSql(
        'DELETE FROM  contact where id=?',
        [id],
        (tx, results) => {
          console.log('Results', results.rowsAffected);
          (tx, results) => {
            console.log('Results', results.rowsAffected);
          };
          if (results.rowsAffected > 0){
            Alert.alert('Success ! deleted successfully')
            navigation.navigate('Contacts');
          } 
        },
        error => {
          console.log(error);
        },
      );
    });
  };

  const getContactData = () => {
    db.transaction(tx => {
      tx.executeSql(
        'SELECT * FROM contact WHERE id = ?',
        [route.params.item.id],
        (tx, results) => {
          var contactTemp = [];
          for (let i = 0; i < results.rows.length; ++i) {
            contactTemp.push(results.rows.item(i));
          }
          setContactList(contactTemp);
          console.log('List', contactTemp);
        },
      );
    });
  };

  useEffect(() => {
    getContactData();
  }, [isFocused]);

  return (
    <View>
      <FlatList
        data={contactList}
        keyExtractor={item => item.id}
        renderItem={({item}) => (
          <View>
            <View style={styles.container}>
              <Image style={styles.profileImage} source={{uri: item.image}} />
              <Text style={styles.name}>{item.name}</Text>
              <Text style={styles.email}>{item.number}</Text>
              <Text style={styles.phone}>{item.landline_number}</Text>
              <View style={styles.buttonContainer}>
                <TouchableOpacity
                  style={styles.button}
                  onPress={() =>
                    navigation.navigate('UpdateContact', {
                      contactData: {
                        name: item.name,
                        number: item.number,
                        landline_number: item.landline_number,
                        image: item.image,
                        id: item.id,
                        favorite_contact : item.favorite_contact
                      },
                    })
                  }>
                  <Icon name="pencil" size={24} color="blue" />
                  <Text style={styles.buttonText}>Update</Text>
                </TouchableOpacity>

                <TouchableOpacity onPress={handleDelete} style={styles.button}>
                  <Icon name="trash" size={24} color="red" />
                  <Text style={styles.buttonText}>Delete</Text>
                </TouchableOpacity>
              </View>
            </View>
          </View>
        )}
      />
    </View>
  );
};

const styles = StyleSheet.create({
  container: {
    flex: 1,
    alignItems: 'center',
    justifyContent: 'center',
    padding: 20,
  },
  profileImage: {
    width: 150,
    height: 150,
    borderRadius: 75,
    marginBottom: 20,
  },
  name: {
    fontSize: 24,
    fontWeight: 'bold',
    marginBottom: 10,
  },
  email: {
    fontSize: 24,
    marginBottom: 10,
  },
  phone: {
    fontSize: 24,
    marginBottom: 10,
  },
  buttonContainer: {
    flexDirection: 'row',
    justifyContent: 'space-around',
    marginTop: 20,
  },
  button: {
    flexDirection: 'row',
    alignItems: 'center',
    padding: 10,
  },
  buttonText: {
    marginLeft: 5,
    fontSize: 16,
  },
});

export default ContactProfile;
