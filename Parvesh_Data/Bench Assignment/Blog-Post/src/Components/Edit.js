import { useState, useEffect } from "react";
import { useSelector, useDispatch } from "react-redux";

import { useNavigate, Link, useParams } from "react-router-dom";
import { Connect } from "react-redux";
import { updatePost } from "../redux/allActions";

function Edit() {
  const [title, setTitle] = useState("");
  const [category, setCategory] = useState("");
  const [content, setContent] = useState("");
  const [titleErr, setTitleErr] = useState(false);
  const dispatch = useDispatch();

  const params = useParams();
  const navigate = useNavigate();

  const { id } = params;

  var Post = useSelector((state) => {
    let postdetail = state.user.items.filter((users) => users.id == id);

    return postdetail;
  });

  useEffect(() => {
    setTitle(Post[0].title);
    setCategory(Post[0].category);
    setContent(Post[0].content);
  }, []);

  function getFormData(e) {
    console.warn(title, category, content);

    e.preventDefault();
    const obj = {
      title: title,
      category: category,
      content: content,
    };
    var data = Post[0];
    Object.assign(data, obj);

    dispatch(updatePost(data));
    navigate("/");
  }

  function userHandler(e) {
    let item = e.target.value;
    if (item.length < 3) {
      setTitleErr(true);
    }
    if (item.length < 3) {
      setTitleErr(false);
    }
  }

  function functionOne(e) {
    setCategory(e.target.value);
  }

  return (
    <div className="container">
      <div className="buttons">
        <Link to="/" className="btn btn-outline-success my-2 my-sm-0">
          Back
        </Link>
      </div>
      <div className="row justify-content-md-center">
        <div className="col-5">
          <form onSubmit={getFormData}>
            <div className="mb-3">
              <label className="form-label">Title</label>
              <input
                type="text"
                className="form-control"
                placeholder="enter the title"
                value={title}
                name="title"
                onChange={(e) => setTitle(e.target.value)}
              />
              {titleErr ? <span>Title is invalid</span> : ""}
            </div>
            <div className="mb-3">
              <label className="form-label">Categories</label>
              <input
                type="text"
                className="form-control"
                placeholder="enter your category"
                name="category"
                value={category}
                onChange={(e) => setCategory(e.target.value)}
              />
            </div>
            <div className="mb-3">
              <label className="form-label">Content</label>
              <textarea
                className="form-control"
                id="exampleFormControlTextarea1"
                rows="3"
                name="content"
                value={content}
                onChange={(e) => setContent(e.target.value)}
              ></textarea>
            </div>
            <div className="row g-2">
              <div className="col-auto">
                <button type="submit" className="btn btn-primary mb-3">
                  Submit
                </button>
              </div>
              <div className="col-auto">
                <button type="submit" className="btn btn-danger mb-3">
                  Cancel
                </button>
              </div>
            </div>
          </form>
        </div>
      </div>
    </div>
  );
}

export default Edit;
