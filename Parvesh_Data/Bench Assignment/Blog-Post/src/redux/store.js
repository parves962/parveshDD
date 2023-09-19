import { createStore, combineReducers } from "redux";
import userReducer from "./reducer/userReducer";

import { composeWithDevTools } from "redux-devtools-extension";

const mainReducer = combineReducers({
  user: userReducer,
});

const commonData = {
  user: {
    items: [
      {
        id: 1,
        title: "Health Post",
        category: "Health",
        content: "stay healthy",
      },
      {
        id: 2,
        title: "Politics Post",
        category: "Politics",
        content: "keep active",
      },
    ],
  },
};

const store = createStore(mainReducer, commonData, composeWithDevTools());

export default store;
