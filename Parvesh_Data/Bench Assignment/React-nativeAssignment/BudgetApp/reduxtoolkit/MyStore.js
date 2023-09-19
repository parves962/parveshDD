import {configureStore} from '@reduxjs/toolkit';
import budgetReducer from './BudgetSlice';

import {combineReducers} from '@reduxjs/toolkit';
import {  persistReducer} from 'redux-persist'
import storage from 'redux-persist/lib/storage';


let persistConfig = {
    key : 'root',
    storage,
};

let rootReducer = combineReducers({
    budgt : budgetReducer
});

let persistedReducer = persistReducer(persistConfig,rootReducer);

export const MyStore  = configureStore({
    reducer: persistedReducer
});

export default MyStore;