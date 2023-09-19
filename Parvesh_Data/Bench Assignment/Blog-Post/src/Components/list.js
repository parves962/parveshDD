import { useNavigate, useParams } from "react-router-dom";
import { Link } from "react-router-dom";
import { useDispatch, useSelector } from "react-redux";
import { deletePost } from "../redux/allActions";
import React, { useState } from "react";
function List() {
  const params = useParams();
  const navigate = useNavigate();
  const { id } = params;
  const dispatch = useDispatch();

  const [count, setCount] = useState(0);

  const handleLike = () => {
    setCount(count + 1);
  };

  var Post = useSelector((state) => {
    let postdetail = state.user.items.filter((users) => users.id == id);

    return postdetail;
  });

  const deleteP = () => {
    dispatch(deletePost(id));
    navigate("/");
  };
  return (
    <div className="container">
      <br></br>
      <div className="justify-content-center">
        <div className="row ">
          <div className="anv">
            <Link to={`/edit/${id}`}>
              <button type="button" className="btn btn-primary">
                Edit
              </button>
            </Link>
            <Link to="/post" className="btn btn-primary">
              New Post
            </Link>
            <button onClick={deleteP} type="button" className="btn btn-danger">
              Delete
            </button>
            <button
              onClick={handleLike}
              type="button"
              className="btn btn-danger mx-2"
            >
              Like : {count}
            </button>
            <Link to="/" className="btn btn-outline-success my-2 my-sm-0">
              Back
            </Link>
          </div>
          {/* <div className="col-2">
            <Link to={`/edit/${id}`}>
              <button type="button" className="btn btn-primary">
                Edit
              </button>
            </Link>
          </div>
          <div className="col-2">
            <Link to="/post" className="btn btn-primary">
              New Post
            </Link>
          </div>
          <div className="col-2">
            <button onClick={deleteP} type="button" className="btn btn-danger">
              Delete
            </button>
          </div>
          <div className="col-2">
            <button type="button" className="btn btn-primary">
              LIKE
            </button>
          </div>

          <div className="col-2">
            <Link to="/" className="btn btn-outline-success my-2 my-sm-0">
              Back
            </Link>
          </div> */}
        </div>
      </div>
      <br></br>
      &nbsp;
      <div className="d-flex justify-content-center">
        <div className="card w-75">
          <div className="card text-center">
            <div className="card-header">{Post[0].title}</div>
            <div className="card-body">
              <h5 className="card-title">
                This is a {Post[0].category} related post
              </h5>
              <p className="card-text">{Post[0].content}</p>
            </div>
            <div className="card-footer text-muted">{Post[0].category}</div>
          </div>
        </div>
      </div>
    </div>
  );
}

export default List;
