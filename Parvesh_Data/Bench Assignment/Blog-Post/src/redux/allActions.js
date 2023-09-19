export const addPost = (data) => {
  return {
    type: "ADD_POST",
    payload: data,
  };
};

export const deletePost = (id) => {
  return {
    type: "DELETE_POST",
    payload: id,
  };
};

export const postInfo = (id) => {
  return {
    type: "POST_INFO",
    payload: id,
  };
};

export const updatePost = (data) => {
  return {
    type: "UPDATE_POST",
    payload: data,
  };
};
