const userReducer = (state = "", action) => {
  switch (action.type) {
    case "ADD_POST":
      return {
        ...state,
        items: [...state.items, action.payload],
      };
    case "DELETE_POST":
      return {
        ...state,
        items: state.items.filter((user) => user.id != action.payload),
      };
    case "POST_INFO":
      let postdetail = state.items.filter((user) => user.id == action.payload);
      console.log("postdetail");
      return {
        ...state,
        users: postdetail.length > 0 ? postdetail[0] : {},
      };
    case "UPDATE_POST":
      return {
        ...state,
        items: state.items.filter((user) =>
          user.id == action.payload.id ? action.payload : user
        ),
      };
    default:
      return state;
  }
};

export default userReducer;
