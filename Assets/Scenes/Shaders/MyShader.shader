// �V�F�[�_�[�̏��
Shader "Unlit/MyShader"
{
    // Unity��ł���������v���p�e�B���
    // �}�e���A����Inspector�E�B���h�E��ɕ\������A�X�N���v�g�ォ����ݒ�ł���
    Properties
    {
        _Color("Main Color", Color) = (1,1,1,1) // Color �v���p�e�B�[ (�f�t�H���g�͔�)   a____
    }
        // �T�u�V�F�[�_�[
        // �V�F�[�_�[�̎�ȏ����͂��̒��ɋL�q����
        // �T�u�V�F�[�_�[�͕����������Ƃ��\���A��{�͈��
        SubShader
    {
        // �p�X
        // 1�̃I�u�W�F�N�g��1�x�̕`��ōs�������������ɏ���
        // �������{������A���G�ȕ`�������Ƃ��͕����������Ƃ��\
        Pass
        {
            CGPROGRAM   // �v���O�����������n�߂�Ƃ����錾

            // �֐��錾
            #pragma vertex vert    // "vert" �֐��𒸓_�V�F�[�_�[�g�p����錾
            #pragma fragment frag  // "frag" �֐����t���O�����g�V�F�[�_�[�Ǝg�p����錾

            // �ϐ��錾
            fixed4 _Color; // �}�e���A������̃J���[   a____

    // ���_�V�F�[�_�[
    float4 vert(float4 vertex : POSITION) : SV_POSITION
    {
        return UnityObjectToClipPos(vertex);
    }

        // �t���O�����g�V�F�[�_�[
        fixed4 frag() : SV_Target
        {
            return _Color;   //a____
        }

        ENDCG   // �v���O�����������I���Ƃ����錾
    }
    }
}