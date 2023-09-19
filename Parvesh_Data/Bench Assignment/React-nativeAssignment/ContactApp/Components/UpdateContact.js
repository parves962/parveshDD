import {
  View,
  Text,
  StyleSheet,
  TextInput,
  TouchableOpacity,
  Alert,
  Image,
} from 'react-native';
import React, {useEffect, useState} from 'react';
import {launchCamera, launchImageLibrary} from 'react-native-image-picker';
import {openDatabase} from 'react-native-sqlite-storage';

let db = openDatabase({name: 'ContactDatabase.db'});
const UpdateContact = ({route, navigation}) => {
  console.log('hellli');
  console.log('update', route.params);
  var num = String(route.params.contactData.number);
  console.log('num', typeof(num));

  const [name, setName] = useState(route.params.contactData.name);
  const [number, setNumber] = useState(num);
  const [landline_number, setlandline_number] = useState(String(route.params.contactData.landline_number));

  const [image, setselectImage] = useState(route.params.contactData.image);
  
 

  console.log("fav",route.params.contactData.favorite_contact)
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

  const updateContact = () => {
    db.transaction(tx => {
      tx.executeSql(
        'UPDATE contact set name=?, number=? , landline_number=?,image=? where id=?',
        [name, number, landline_number, image,route.params.contactData.id],
        (tx, results) => {
          Alert.alert('Success! Contact Updated Suceessfully','',[{
            text:'ok',
            onPress:()=>{
              navigation.navigate('Contacts')
            }
          }])
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
        title="Image"
        onPress={() => {
          ImagePicker();
        }}><Text>Upload Image</Text></TouchableOpacity>
      <TextInput
        placeholder="Enter User Name"
        style={styles.input}
        value={name}
        onChangeText={txt => setName(txt)}
      />
      <TextInput
        placeholder="Enter Number"
        value={number}
        onChangeText={txt => setNumber(txt)}
        style={[styles.input, {marginTop: 20}]}
      />
      <TextInput
        placeholder="Enter User Address"
        value={landline_number}
        onChangeText={txt => setlandline_number(txt)}
        style={[styles.input, {marginTop: 20}]}
      />

      <TouchableOpacity
        style={styles.addBtn}
        onPress={() => {
          updateContact();
        }}>
        <Text style={styles.btnText}>Update Contact</Text>
      </TouchableOpacity>
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
    marginTop:10
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
    marginTop: 30,
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
    marginTop: 30,

    alignSelf: 'center',
  },
});

export default UpdateContact;
