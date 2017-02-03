/**
 * Definition for a binary tree node.
 * function TreeNode(val) {
 *     this.val = val;
 *     this.left = this.right = null;
 * }
 */
/**
 * @param {number[]} inorder
 * @param {number[]} postorder
 * @return {TreeNode}
 */

var buildTree = function (inorder, postorder) {

    var length = inorder.length;
    if (length === 0) {
        return null;
    }

    if (length === 1) {
        return new TreeNode(inorder[0]);
    }

    var Root = new TreeNode(postorder[length - 1]);
    var indexInOrder = inorder.indexOf(Root.val);

    Root.left = buildSubTree(inorder, postorder, 0, 0, indexInOrder);

    Root.right = buildSubTree(inorder, postorder, indexInOrder + 1, indexInOrder, length - indexInOrder - 1);



    return Root;
};

var buildSubTree = function (inorder, postorder, inStart, postStart, length) {

    if (length === 0) {
        return null;
    }

    if (length === 1) {
        return new TreeNode(inorder[inStart]);
    }

    var Root = new TreeNode(postorder[postStart + length - 1]);
    var indexInOrder = inorder.indexOf(Root.val);
    var leftLength = indexInOrder - inStart;
    var rightLength = length - leftLength - 1;

    Root.left = buildSubTree(inorder, postorder, inStart, postStart, leftLength);
    Root.right = buildSubTree(inorder, postorder, indexInOrder + 1, postStart + leftLength, rightLength);

    return Root;
};
