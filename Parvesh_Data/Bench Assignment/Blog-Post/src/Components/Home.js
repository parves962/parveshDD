import List from "./list";
import React, { useState } from "react";
import Post from "./Post";
import { useNavigate } from "react-router-dom";
import { useSelector } from "react-redux";
import {
  BrowserRouter as Router,
  Route,
  Link,
  Navigate,
} from "react-router-dom";
import Navbar from "./Navbar";
function Home() {
  var Post = [];

  Post = useSelector((state) => {
    console.log(state);
    return state.user.items;
  });

  return (
    <div className="container">
      <br></br>
      <div className="buttons">
        <Link to="/post" className="btn btn-outline-success my-2 my-sm-0">
          New Post
        </Link>
      </div>
      <br></br>
      <br></br>
      &nbsp;
      <div className="container">
        <div className="row justify-content-md-center">
          <div className="list-group">
            {Post.map((data) => (
              <div className="card text-center">
                <div className="card-header">{data.title}</div>
                <div className="card-body">
                  <Link to={`/list/${data.id}`} className="btn btn-primary">
                    Read More
                  </Link>
                </div>
              </div>
            ))}
          </div>
        </div>
      </div>
    </div>
  );
}

export default Home;
