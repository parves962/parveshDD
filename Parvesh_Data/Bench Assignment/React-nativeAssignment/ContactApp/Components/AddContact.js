import {
  View,
  Text,
  StyleSheet,
  TextInput,
  TouchableOpacity,
  Image,
  Button,
} from 'react-native';
import React, {useEffect, useState} from 'react';
import {launchCamera, launchImageLibrary} from 'react-native-image-picker';
import RNFS from 'react-native-fs';
import {NavigationContainer} from '@react-navigation/native';
import {createNativeStackNavigator} from '@react-navigation/native-stack';
import {openDatabase} from 'react-native-sqlite-storage';
import ImagePicker, {openPicker} from 'react-native-image-crop-picker';
import Ionicons from 'react-native-vector-icons/Ionicons';

let db = openDatabase({name: 'ContactDatabase.db'});

const AddContact = ({navigation}) => {
  
  const link = "https://i.pinimg.com/736x/8b/16/7a/8b167af653c2399dd93b952a48740620.jpg";
  const [name, setName] = useState('');
  const [number, setNumber] = useState(0);
  const [landline_number, setlandline_number] = useState(0);
  const [image, setselectImage] = useState(link);
  const [favorite,setFavorite] = useState(false);

  const ImagePicker = () => {
    let options = {
      storageOptions: {
        path: 'image',
      },
    };

    launchImageLibrary(options, response => {
      setselectImage(response.assets[0].uri);
      
    });
  };

  const makeFav=()=>{
    setFavorite(true);
    console.log("fav",favorite);
  }
 

  const saveUser = () => {
    
    db.transaction(function (tx) {
      tx.executeSql(
        'INSERT INTO contact (name, number, landline_number,image,favorite_contact) VALUES (?,?,?,?,?)',
        [name, number, landline_number, image,favorite],
        (tx, results) => {
          console.log('Results', results.rowsAffected);
          if (results.rowsAffected > 0) navigation.navigate('Contacts');
        },
        error => {
          console.log(error);
        },
      );
    });
  };

  return (
    <View style={styles.container}>
      <Image style={styles.img} value={image} source={{uri: image}}></Image>
      <TouchableOpacity
        style={styles.imgpc}
        
        onPress={() => {
          ImagePicker();
        }}><Text>Upload Image</Text></TouchableOpacity>
      <TextInput
        placeholder="Enter  Name"
        style={styles.input}
        value={name}
        onChangeText={(txt) => setName(txt)}
      />
      <TextInput
        placeholder="Enter phone number"
        value={number}
        keyboardType="numeric"
        onChangeText={(txt) => setNumber(txt)}
        style={[styles.input, {marginTop: 20}]}
      />
      <TextInput
        placeholder="Enter Landlinenumber"
        value={landline_number}
        keyboardType="numeric"
        onChangeText={(txt) => setlandline_number(txt)}
        style={[styles.input, {marginTop: 20}]}
      />
      <View style={styles.fav}>
        <Text>Add to Favourite</Text>
        <TouchableOpacity onPress={()=>{
          makeFav();
        }}>
        <Ionicons name='star' style={{marginLeft:70}}size={30}  ></Ionicons>
        </TouchableOpacity>
        
      </View>
      <TouchableOpacity
        style={styles.addBtn}
        onPress={() => {
          saveUser();
        }}>
        <Text style={styles.btnText}>Save User</Text>
      </TouchableOpacity>
      <Button
        title="go to home page"
        onPress={() => navigation.navigate('Contacts')}></Button>
    </View>
  );
};

const styles = StyleSheet.create({
  container: {
    flex: 1,
  },
  img: {
    width: 150,
    height: 150,
    borderRadius: 75,
    marginBottom: 10,
   
    alignSelf: 'center',
    paddingLeft: 20,
  },
  input: {
    width: '80%',
    height: 50,
    borderRadius: 10,
    borderWidth: 0.3,
    alignSelf: 'center',
    paddingLeft: 20,
    marginTop: 50,
  },
  addBtn: {
    backgroundColor: 'purple',
    width: '80%',
    height: 50,
    borderRadius: 10,
    justifyContent: 'center',
    alignItems: 'center',
    marginTop: 10,
    marginBottom: 40,
    alignSelf: 'center',
  },
  btnText: {
    color: '#fff',
    fontSize: 18,
  },
  imgpc: {
    backgroundColor: 'yellow',
    width: '50%',
    height: 50,
    borderRadius: 10,
    justifyContent: 'center',
    alignItems: 'center',
    marginTop: 10,
    alignSelf: 'center',
  },
  fav : {
    width: '80%',
    height: 50,
    flexDirection:'row',
    alignSelf: 'center',
    paddingLeft: 20,
    marginTop: 20,
  }
});

export default AddContact;
