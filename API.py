from flask import Flask, request, jsonify
import QueryScript as query
app = Flask(__name__)


@app.route("/login", methods= ['GET', 'POST'])
def Login():
    if not request.is_json:
        return jsonify({'success': False, 'message': 'Missing Json'}), 400
    data = request.get_json()
    if not data:
        return jsonify({'success': False, 'message': 'Invalid Json'}), 400
    login = data.get('login')
    password = data.get('password')
    result = query.SignIn(login, password)
    return jsonify({'login': result[0][0], 'money': result[0][1]}), 200
    
@app.route("/registration", methods=['GET', 'POST'])
def Registration():
    if not request.is_json:
        return jsonify({'success': False, 'message': 'Missing Json'}), 400
    data = request.get_json()
    if not data:
        return jsonify({'success': False, 'message': 'Invalid Json'}), 400
    login = data.get('login')
    password = data.get('password')
    result = query.Registration(login, password)
    return jsonify({'login': result[0][0], 'money': result[0][1]}), 201
    
@app.route("/buy_ticket" , methods=['GET', 'POST'])
def BuyTicket():
    if not request.is_json:
        return jsonify({'success': False, 'message': 'Missing Json'}), 400
    data = request.get_json()
    if not data:
        return jsonify({'success': False, 'message': 'Invalid Json'}), 400
    login = data.get('login')
    money = data.get('money')
    query.BuyTicket(login, money)
    return jsonify({'success': True}), 200


if __name__ == '__main__':
    app.run(debug=False)