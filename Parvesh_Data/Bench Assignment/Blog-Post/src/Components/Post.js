import { useState } from "react";
import shortid from "shortid";
import { useDispatch } from "react-redux";
import { addPost } from "../redux/allActions";
import { useNavigate, Link } from "react-router-dom";
function Post() {
  //console.log("props", props);

  const dispatch = useDispatch();
  const navigate = useNavigate();

  const [title, setTitle] = useState("");
  const [category, setCategory] = useState("");
  const [content, setContent] = useState("");
  const [titleErr, setTitleErr] = useState(false);

  // const [inputField, setInputField] = useState({
  //   title: "",
  //   category: "",
  //   content: "",
  // });

  function getFormData(e) {
    console.warn(title, category, content);

    e.preventDefault();
    const obj = {
      title: title,
      category: category,
      content: content,
    };
    Object.assign(obj, { id: shortid.generate() });
    console.warn("obj", obj);
    dispatch(addPost(obj));
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
    // <Link></Link>
    <div className="container">
      <div className="buttons">
        <Link to="/" className="btn btn-outline-success my-2 my-sm-0">
          Back
        </Link>
      </div>
      &nbsp; &nbsp;
      <div className="row justify-content-md-center">
        <div className="col-5">
          <form onSubmit={getFormData}>
            <div className="mb-3">
              <label className="form-label">Title</label>
              <input
                type="text"
                className="form-control"
                placeholder="enter the title"
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
                onChange={(e) => setCategory(e.target.value)}
              />
            </div>
            <div className="mb-3">
              <label className="form-label">Content</label>
              <textarea
                className="form-control"
                id="exampleFormControlTextarea1"
                rows="3"
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
                <Link to="/" className="btn btn-danger mb-3">
                  Cancel
                </Link>
              </div>
            </div>
          </form>
        </div>
      </div>
    </div>
  );
}

export default Post;
