import React from 'react';



import { createStackNavigator } from '@react-navigation/stack';
import { NavigationContainer } from '@react-navigation/native';
import Budgetentry from './Components/budgetentry';
import Budgetlisting from './Components/budgetlisting';
import 'react-native-gesture-handler';

const Stack = createStackNavigator();

const Main = () => {
  return (
    <NavigationContainer>
      <Stack.Navigator screenOptions={{
        headerTitleAlign: 'center',
      }}>
        <Stack.Screen name="BudgetApp" component={Budgetentry} options={{title:'Budget Entry'}}/>
        <Stack.Screen name="BudgetListing" component={Budgetlisting} options={{title:'Budget List'}}/>
      </Stack.Navigator>
    </NavigationContainer>

  )
}

export default Main;