import { createSlice } from "@reduxjs/toolkit";

const initialState = {
    items:[],
};
const BudgetSlice = createSlice({
    name : 'budget',
    initialState,
    reducers : {
        addItem:(state,action)=>{
           
           state.items.push(action.payload);
        },
    },
});

export const {addItem} = BudgetSlice.actions;
export default BudgetSlice.reducer;

