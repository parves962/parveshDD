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

import { createDrawerNavigator } from '@react-navigation/drawer';
import Favorite from './Favorite';
import ContactList from './ContactList';

const Drawer = createDrawerNavigator();

function MyDrawer() {
  return (

    <Drawer.Navigator initialRouteName='Contacts'>
        
      <Drawer.Screen name="FavoriteContact" component={Favorite} options={{ headerShown: true }} />
      <Drawer.Screen name="Contacts" component={ContactList} options={{ headerShown: true }} />
    </Drawer.Navigator>
  );
}

export default MyDrawer;