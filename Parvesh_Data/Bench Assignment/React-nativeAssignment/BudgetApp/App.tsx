/**
 * Sample React Native App
 * https://github.com/facebook/react-native
 *
 * @format
 */

import React from 'react';





import { Provider } from 'react-redux';
import Main from './Main';

import MyStore from './reduxtoolkit/MyStore';
import { persistStore, persistReducer, FLUSH, REHYDRATE, PAUSE, PERSIST, PURGE, REGISTER } from 'redux-persist'

import { PersistGate } from 'redux-persist/integration/react';



let persistor = persistStore(MyStore);

const App = () => {
  return (
    <Provider store={MyStore}>
      <PersistGate persistor={persistor}>
        <Main />
      </PersistGate>
    </Provider>
  );
};

export default App;
