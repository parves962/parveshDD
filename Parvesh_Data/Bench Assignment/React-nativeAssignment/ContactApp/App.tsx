/**
 * Sample React Native App
 * https://github.com/facebook/react-native
 *
 * @format
 */

import React from 'react';
import { View, Text, StyleSheet, TouchableOpacity, FlatList, Image } from 'react-native';
import ContactList from './Components/ContactList';
import AddContact from './Components/AddContact';
import UpdateContact from './Components/UpdateContact';
import { NavigationContainer } from '@react-navigation/native';
import { createNativeStackNavigator } from '@react-navigation/native-stack';
import ContactProfile from './Components/ContactProfile';
import Favorite from './Components/Favorite';
import MyDrawer from './Components/Drawernav';

const Stack = createNativeStackNavigator();
const App = () => {
  return (
    <NavigationContainer>
      <Stack.Navigator screenOptions={{
        headerTitleAlign: 'center',
      }}>
        <Stack.Screen
          name="Drawer"
          component={MyDrawer}
          options={{ headerShown: false }}
        />

        <Stack.Screen name='AddContact' component={AddContact} options={{ title: 'Add Contact' }}></Stack.Screen>
        <Stack.Screen name='UpdateContact' component={UpdateContact} options={{ title: 'Update Contact' }}></Stack.Screen>
        <Stack.Screen name='ContactProfile' component={ContactProfile} options={{ title: 'Contact profile' }}></Stack.Screen>

      </Stack.Navigator>
    </NavigationContainer>

  )
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    alignItems: 'center',
    justifyContent: 'center',
  },
});
export default App;