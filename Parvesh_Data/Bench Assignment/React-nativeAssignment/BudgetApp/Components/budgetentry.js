import {
    View,
    Text,
    StyleSheet,
    TextInput,
    TouchableOpacity,
    Image,
    Button,
    TextDecoder
  } from 'react-native';
  import React, {useEffect, useState} from 'react';
  import {useDispatch} from 'react-redux';
import { addItem } from '../reduxtoolkit/BudgetSlice';
  
  const Budgetentry = ({navigation})=>{

    const [item_name, setName] = useState('');
    const [planned_amout, setplanned_amount] = useState('');
    const [actual_amount, setactual_amount] = useState('');

     const dispatch = useDispatch();

    const additem=()=>{
        const obj = {
            name : item_name,
            pamount : planned_amout,
            actamount : actual_amount
        };
        setName(''),
        setactual_amount(''),
        setplanned_amount('')
        
        dispatch(addItem(obj));
        navigation.navigate('BudgetListing');
    };
    

    return(<View style={styles.container}>
        <Text style={styles.heading}>Item Vise Budget</Text>
        <TextInput
        placeholder="Enter item name"
        style={styles.input}
        value={item_name}
        onChangeText={(txt) => setName(txt)}
      />
      <TextInput
        placeholder="Enter planned amount"
        value={planned_amout}
        keyboardType="numeric"
        onChangeText={(txt) => setplanned_amount(txt)}
        style={[styles.input, {marginTop: 20}]}
      />
      <TextInput
        placeholder="Enter actual amount"
        value={actual_amount}
        keyboardType="numeric"
        onChangeText={(txt) => setactual_amount(txt)}
        style={[styles.input, {marginTop: 20}]}
      />
      <TouchableOpacity
        style={styles.addBtn}
        onPress={() => {additem();}}>
        <Text style={styles.btnText}>Add Item</Text>
      </TouchableOpacity>
      <TouchableOpacity
        style={styles.addBtn1}
        onPress={() => navigation.navigate('BudgetListing')}>
        <Text style={styles.btnText1}>Budget List</Text>
      </TouchableOpacity>
    </View>)
  }

  const styles = StyleSheet.create({
    container: {
      flex: 1,
    },
    heading : {
        marginTop:30,
        alignContent:'center',
        textAlign:'center',
        fontSize: 25
    },
    
    input: {
      width: '80%',
      height: 50,
      borderRadius: 10,
      borderWidth: 0.3,
      alignSelf: 'center',
      paddingLeft: 20,
      marginTop: 50,
      paddingTop:20
      
    },
    addBtn: {
      backgroundColor: 'green',
      width: '80%',
      height: 50,
      borderRadius: 10,
      justifyContent: 'center',
      alignItems: 'center',
      marginTop: 30,
      marginBottom: 40,
      alignSelf: 'center',
    },
    addBtn1: {
        backgroundColor: 'orange',
        width: '80%',
        height: 50,
        borderRadius: 10,
        justifyContent: 'center',
        alignItems: 'center',
        marginTop: 30,
        marginBottom: 40,
        alignSelf: 'center',
      },
});

  export default Budgetentry;