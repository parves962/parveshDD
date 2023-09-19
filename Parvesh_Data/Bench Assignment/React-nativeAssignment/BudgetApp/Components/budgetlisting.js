import {
    View,
    Text,
    StyleSheet,
    TextInput,
    TouchableOpacity,
    Image,
    Button,
    FlatList
  } from 'react-native';
  import React, {useEffect, useState} from 'react';
  import {useSelector} from 'react-redux';
import { SafeAreaView } from 'react-native-safe-area-context';
  
  const Budgetlisting = ()=>{

   
    const b_list = useSelector((state) => state.budgt.items);
    console.log("data",b_list);

    return(<View>
        
        <FlatList
        data={b_list}
        keyExtractor={item => item.id}
        renderItem={({item}) => (
          <View>
            <SafeAreaView>
            <View style={styles.container}>
              
              <Text style={styles.txt}>Item : {item.name}</Text>
              <Text style={styles.txt}>PlannedAmt : {item.pamount}</Text>
              <Text style={styles.txt}>ActualAmt : {item.actamount}</Text>
            </View>
            </SafeAreaView>
            
          </View>
        )}
      />
    </View>)
  }

  const styles = StyleSheet.create({
    container: {
      backgroundColor:'orange',
      flex: 1,
      alignItems: 'center',
      justifyContent: 'center',
      padding: 20,
      flexDirection:'row',
      paddingTop:10,
      marginBottom:10,
      borderRadius:10
    },
    txt : {
      paddingLeft:20,
      fontSize:15
    }
    
  });
  export default Budgetlisting;